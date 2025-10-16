using StockTrackingApp.Entities.DTO;
using System.Collections.Generic;

namespace StockTrackingApp.Businiess.Contracts
{
    /// <summary>
    /// Stok hareketleri ile ilgili servis işlemleri
    /// </summary>
    public interface IInventoryLogService
    {

        void AddLog(int itemId, string actionType, int quantityChanged);


        List<ChangeDto> GetAllLogs();


        List<ChangeDto> GetMonthlyChanges(int year = 0, int month = 0);

        int ClearOldLogs(int monthsAgo);
    }
}
