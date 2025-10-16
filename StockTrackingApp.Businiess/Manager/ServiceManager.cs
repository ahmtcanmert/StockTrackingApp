using StockTrackingApp.Business;
using StockTrackingApp.Businiess.Contracts;
using StockTrackingApp.DataAccess;
using StokTakip.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingApp.Businiess.Manager
{
    public class ServiceManager : IServiceManager
    {
        public ServiceManager()
        {
            var context = new InventoryContext();
            var inventoryRepository = new InventoryRepository(context);
            var inventoryLogRepository = new InventoryLogRepository(context);

            InventoryService = new InventoryManager(inventoryRepository);
            InventoryLogService = new InventoryLogManager(inventoryLogRepository);
        }

        public IInventoryLogService InventoryLogService { get; }

        public IInventoryService InventoryService { get; }
    }
}
