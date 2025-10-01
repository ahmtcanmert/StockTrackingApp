using StokTakip.Entities;
using System.Collections.Generic;

namespace StokTakip.Entities.Repository
{
    public interface IInventoryLogRepository
    {
        void AddLog(InventoryLog log);
        List<InventoryLog> GetLogs();
        List<InventoryLog> GetLogsByMonth(int year, int month);
        List<int> GetAllYears();
        void Save();
    }
}
