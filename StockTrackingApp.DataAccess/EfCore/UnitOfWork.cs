using StockTrackingApp.DataAccess.Contracts;
using StokTakip.Entities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingApp.DataAccess.EfCore
{
    public class UnitOfWork : IUnitOfWork
    {
        public IInventoryLogRepository InventoryLogs { get; private set; }
        public IInventoryRepository InventoryItems { get; private set; }

        public UnitOfWork()
        {
            InventoryLogs = new InventoryLogRepository();
            InventoryItems = new InventoryRepository();
        }

        public void Save()
        {
            InventoryLogs.Save();
            InventoryItems.Save();
        }
    }
}
