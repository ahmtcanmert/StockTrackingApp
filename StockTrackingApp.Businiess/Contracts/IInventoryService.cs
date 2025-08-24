using StokTakip.Entities;
using System.Collections.Generic;

namespace StockTrackingApp.Business
{
    public interface IInventoryService
    {
        List<InventoryItem> GetAllItems();
        InventoryItem GetItemById(int id);
        void AddItem(InventoryItem item);
        void UpdateItem(InventoryItem item);
        void DeleteItem(int id);
        void IncreaseStoreStock(int id, int quantity);
        void DecreaseStoreStock(int id, int quantity);
        void IncreaseShipmentStock(int id, int quantity);
        void DecreaseShipmentStock(int id, int quantity);
    }
}
