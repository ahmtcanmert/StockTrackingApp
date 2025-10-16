using StockTrackingApp.Entities.DTO;
using StokTakip.Entities;
using System.Collections.Generic;

namespace StockTrackingApp.Business
{
    public interface IInventoryLogService
    {

        void AddLog(int itemId, string actionType, int quantityChanged);


        List<InventoryLog> GetAllLogs();


        List<InventoryLog> GetMonthlyChanges(int year, int month);


        int ClearOldLogs(int monthsAgo = 4);
    }
}
