using StockTrackingApp.Entities.DTO;
using StokTakip.Entities;
using StokTakip.Entities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StockTrackingApp.Business
{
    public class InventoryLogManager : IInventoryLogService
    {
        private readonly IInventoryLogRepository _logRepository;

        public InventoryLogManager(IInventoryLogRepository logRepository)
        {
            _logRepository = logRepository;
        }

        public void AddLog(int itemId, string actionType, int quantityChanged)
        {
            var log = new InventoryLog
            {
                Id = itemId,
                ActionType = actionType,
                QuantityChanged = quantityChanged,
                ActionDate = DateTime.Now
            };

            _logRepository.AddLog(log);
            _logRepository.Save();
        }

        public List<InventoryLog> GetAllLogs()
        {
            return _logRepository.GetLogs();
        }

        public List<InventoryLog> GetMonthlyChanges(int year, int month)
        {
            return _logRepository.GetLogsByMonth(year, month);
        }


        public int ClearOldLogs(int monthsAgo = 4)
        {
            var cutoffDate = DateTime.Now.AddMonths(-monthsAgo);
            return _logRepository.DeleteOldLogs();
        }


    }
}
