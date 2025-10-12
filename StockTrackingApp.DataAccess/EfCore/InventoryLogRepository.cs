using Microsoft.EntityFrameworkCore;
using StockTrackingApp.Entities.DTO;
using StokTakip.DataAccess;
using StokTakip.Entities;
using StokTakip.Entities.Repository;
using System.Collections.Generic;
using System.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace StockTrackingApp.DataAccess
{
    public class InventoryLogRepository : IInventoryLogRepository
    {
        private readonly InventoryContext _context;

        public InventoryLogRepository()
        {
            _context = new InventoryContext();
            _context.Database.EnsureCreated();
        }

        public void AddLog(InventoryLog log)
        {
            _context.InventoryLogs.Add(log);
        }

        public List<InventoryLog> GetLogs() => _context.InventoryLogs.ToList();

        public List<InventoryLog> GetLogsByMonth(int year, int month)
        {
            return _context.InventoryLogs
                .Where(l => l.ActionDate.Year == year && l.ActionDate.Month == month)
                .ToList();
        }


        // Aylık
        public List<ChangeDto> GetYearlyChanges(int year)
        {
            var logs = _context.InventoryLogs
                .Where(l => l.ActionDate.Year == year)
                .GroupBy(l => new { l.InventoryItem.ProductName, l.InventoryItem.Brand, l.InventoryItem.ColorCode })
                .Select(g => new ChangeDto
                {
                    ProductName = g.Key.ProductName,
                    Brand = g.Key.Brand,
                    ColorCode = g.Key.ColorCode,
                    Year = year,
                    Month = null, // yıl bazlı rapor
                    QuantityChanged = g.Sum(x => x.QuantityChanged) // veya x.QuantityIn - x.QuantityOut
                })
                .ToList();

            return logs;
        }

        public List<ChangeDto> GetMonthlyChanges(int? year, int? month)
        {
            return _context.InventoryLogs
                .Where(l => (!year.HasValue || l.ActionDate.Year == year.Value) &&
                            (!month.HasValue || l.ActionDate.Month == month.Value))
                .GroupBy(l => new
                {
                    l.InventoryItem.ProductName,
                    l.InventoryItem.Brand,
                    l.InventoryItem.ColorCode,
                    l.ActionDate.Year,
                    l.ActionDate.Month
                })
                .Select(g => new ChangeDto
                {
                    ProductName = g.Key.ProductName,
                    Brand = g.Key.Brand,
                    ColorCode = g.Key.ColorCode,
                    Year = g.Key.Year,
                    Month = g.Key.Month,

                    QuantityChanged = g.Sum(x => x.ActionType == "Ekleme"
                                                 ? x.QuantityChanged
                                                 : -x.QuantityChanged)
                })
                .ToList();
        }


        public List<int> GetAllYears()
        {
            return _context.InventoryLogs
                .Select(l => l.ActionDate.Year)
                .Distinct()
                .OrderByDescending(y => y)
                .ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}

