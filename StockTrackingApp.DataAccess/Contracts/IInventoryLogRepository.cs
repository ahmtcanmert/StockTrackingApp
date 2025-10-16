using StockTrackingApp.Entities.DTO;
using StokTakip.Entities;
using System.Collections.Generic;

namespace StokTakip.Entities.Repository
{
    public interface IInventoryLogRepository
    {
        void AddLog(InventoryLog log);
        List<InventoryLog> GetLogs();
        List<ChangeDto> GetMonthlyChanges(int? monthsAgo = null); // nullable monthsAgo
        int DeleteOldLogs(int monthsAgo);
        void Save();
    }
}
