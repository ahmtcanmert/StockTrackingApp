using StockTrackingApp.Entities.DTO;
using StokTakip.Entities;
using System.Collections.Generic;

namespace StockTrackingApp.Business
{
    public interface IInventoryService
    {
        List<InventoryItem> GetAllItems();
        InventoryItem GetItemById(int id);
        void AddItem(InventoryItem item);
        void UpdateItem(UpdateInventoryItemDto dto);
        void DeleteItem(int id);
        void IncreaseStoreStock(int id, int quantity);
        void DecreaseStoreStock(int id, int quantity);
        void IncreaseShipmentStock(int id, int quantity);
        void DecreaseShipmentStock(int id, int quantity);
        void AddLog(int itemId, string actionType, int quantityChanged);
    }
}
