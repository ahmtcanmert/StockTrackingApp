using StokTakip.DataAccess;
using StokTakip.Entities;
using StokTakip.Entities.Repository;
using System.Collections.Generic;
using System.Linq;

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

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
