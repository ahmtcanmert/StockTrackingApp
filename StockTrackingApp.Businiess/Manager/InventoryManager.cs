using StockTrackingApp.DataAccess;
using StokTakip.Entities;
using StokTakip.Entities.Repository;
using System.Collections.Generic;

namespace StockTrackingApp.Business
{
    public class InventoryManager : IInventoryService
    {
        private readonly IInventoryRepository _repository;

        public InventoryManager(IInventoryRepository repository)
        {
            _repository = repository;
        }

        public List<InventoryItem> GetAllItems() => _repository.GetAll();

        public InventoryItem GetItemById(int id) => _repository.GetById(id);

        public void AddItem(InventoryItem item)
        {
            _repository.Add(item);
            _repository.Save();
        }

        public void UpdateItem(InventoryItem item)
        {
            _repository.Update(item);
            _repository.Save();
        }

        public void DeleteItem(int id)
        {
            var entity = _repository.GetById(id);
            if (entity != null)
            {
                entity.IsDeleted = true; // Soft delete
                _repository.Update(entity);
                _repository.Save();

            }
        }

        public void IncreaseStoreStock(int id, int quantity)
        {
            _repository.IncreaseStoreStock(id, quantity);
            _repository.Save();

        }

        public void DecreaseStoreStock(int id, int quantity)
        {
            _repository.DecreaseStoreStock(id, quantity);
            _repository.Save();

        }

        public void IncreaseShipmentStock(int id, int quantity)
        {
            _repository.IncreaseShipmentStock(id, quantity);
            _repository.Save();
        }

        public void DecreaseShipmentStock(int id, int quantity)
        {
            _repository.DecreaseShipmentStock(id, quantity);    
            _repository.Save();

        }
        public int ReelStock(int id,int quantity) 
        { 
            _repository.ReduceStockFromStoreAndShipment(id, quantity);
            var item=GetItemById(id);
            var reelStock=item.QuantityInStore-item.QuantityInShipment;
            return reelStock;
        }
 
    }
}
