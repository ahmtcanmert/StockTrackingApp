using Microsoft.EntityFrameworkCore;
using StockTrackingApp.Entities.DTO;
using StokTakip.DataAccess;
using StokTakip.Entities;
using StokTakip.Entities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StockTrackingApp.DataAccess
{
    public class InventoryLogRepository : IInventoryLogRepository
    {
        private readonly InventoryContext _context;

        public InventoryLogRepository(InventoryContext context)
        {
            _context = context;
        }

        public void AddLog(InventoryLog log)
        {
            _context.InventoryLogs.Add(log);
            _context.SaveChanges();
        }

        public List<InventoryLog> GetLogs() => _context.InventoryLogs.ToList();

        public List<ChangeDto> GetMonthlyChanges(int? monthsAgo)
        {
            var fromDate = DateTime.Now.AddMonths(-monthsAgo.Value);

            return _context.InventoryLogs
                .Where(l => l.ActionDate >= fromDate)
                .GroupBy(l => new
                {
                    l.InventoryItem.ProductName,
                    l.InventoryItem.Brand,
                    l.InventoryItem.ColorCode,
                    l.ActionDate.Month,
                    l.ActionDate.Year
                })
                .Select(g => new ChangeDto
                {
                    ProductName = g.Key.ProductName,
                    Brand = g.Key.Brand,
                    ColorCode = g.Key.ColorCode,
                    Year = g.Key.Year,
                    Month = g.Key.Month,
                    Incoming = g.Where(x => x.QuantityChanged > 0).Sum(x => x.QuantityChanged),
                    Outgoing = g.Where(x => x.QuantityChanged < 0).Sum(x => -x.QuantityChanged)
                })
                .ToList();
        }

        public int DeleteOldLogs(int monthsAgo)
        {
            var cutoff = DateTime.Now.AddMonths(-monthsAgo);

            var oldLogs = _context.InventoryLogs
                .Where(l => l.ActionDate < cutoff)
                .ToList();

            if (oldLogs.Any())
            {
                _context.InventoryLogs.RemoveRange(oldLogs);
                _context.SaveChanges();
            }

            return oldLogs.Count;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
