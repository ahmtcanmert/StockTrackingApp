using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Entities.Repository
{
    public interface IInventoryRepository
    {
        List<InventoryItem> GetAll();
        InventoryItem GetById(int id);
        void Add(InventoryItem item);
        void Update(InventoryItem item);
        void Delete(int id);
        void Save();
        void IncreaseStoreStock(int id, int quantity);
        void DecreaseStoreStock(int id, int quantity);
        void IncreaseShipmentStock(int id, int quantity);
        void DecreaseShipmentStock(int id, int quantity);
        void ReduceStockFromStoreAndShipment(int id, int quantity);

    }
}
