using StokTakip.Entities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingApp.DataAccess.Contracts
{
    public interface IUnitOfWork
    {
        IInventoryLogRepository InventoryLogs { get; }
        IInventoryRepository InventoryItems { get; }

        void Save();
    }
}
