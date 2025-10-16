using StockTrackingApp.Businiess.Contracts;
using StockTrackingApp.Entities.DTO;
using StokTakip.Entities;
using StokTakip.Entities.Repository;
using System.Collections.Generic;

namespace StockTrackingApp.Business.Manager
{
    public class InventoryLogManager : IInventoryLogService
    {
        private readonly IInventoryLogRepository _repository;

        public InventoryLogManager(IInventoryLogRepository repository)
        {
            _repository = repository;
        }

        public void AddLog(int itemId, string actionType, int quantityChanged)
        {
            var log = new InventoryLog
            {
                InventoryItemId = itemId,
                ActionType = actionType,
                QuantityChanged = quantityChanged,
                ActionDate = DateTime.Now
            };
            _repository.AddLog(log);
            _repository.Save();
        }

        public List<ChangeDto> GetAllLogs()
        {
            return _repository.GetMonthlyChanges(4); // son 4 ay
        }

        public List<ChangeDto> GetMonthlyChanges(int year, int month)
        {
            return _repository.GetMonthlyChanges(4); // son 4 ay
        }

        public int ClearOldLogs(int monthsAgo)
        {
            return _repository.DeleteOldLogs(monthsAgo);
        }
    }
}
