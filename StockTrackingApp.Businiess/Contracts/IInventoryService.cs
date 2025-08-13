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
        string DecreaseStock(int id, int quantity);
        void IncreaseStock(int id, int quantity);
    }
}
