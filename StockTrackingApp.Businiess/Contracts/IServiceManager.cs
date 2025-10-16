using StockTrackingApp.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingApp.Businiess.Contracts
{
    public interface IServiceManager
    {
        IInventoryLogService InventoryLogService{ get; }
        IInventoryService InventoryService { get; }

    }
}
