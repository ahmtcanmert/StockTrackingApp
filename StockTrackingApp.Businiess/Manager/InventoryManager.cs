using StockTrackingApp.DataAccess;
using StockTrackingApp.Entities.DTO;
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

        public void UpdateItem(UpdateInventoryItemDto dto)
        {
            _repository.Update(dto);
            _repository.Save();
        }

        public void DeleteItem(int id)
        {
            _repository.SoftDelete(id);
            _repository.Save();
        }


        public void IncreaseStoreStock(int id, int quantity)
        {
            _repository.IncreaseStoreStock(id, quantity);
            _repository.AddLog(id, "Mağaza stoğu arttı", quantity);
            _repository.Save();

        }

        public void DecreaseStoreStock(int id, int quantity)
        {
            var item = _repository.GetById(id);
            var storeStock = (item.QuantityInStore - item.QuantityInShipment);
            if (storeStock < quantity)
                throw new Exception($"Yetersiz mağaza stoğu. Mevcut: {storeStock}");

            _repository.DecreaseStoreStock(id, quantity);
            _repository.Save();
        }

        public void IncreaseShipmentStock(int id, int quantity)
        {
            var item = _repository.GetById(id);
            var storeStock = (item.QuantityInStore - item.QuantityInShipment);

            if (storeStock < quantity)
                throw new Exception($"Yetersiz mağaza stoğu. Mevcut: {storeStock}");

            _repository.IncreaseShipmentStock(id, quantity);
            _repository.Save();
        }
        public void CompleteOrder(int id, int quantity)
        {
            var item = _repository.GetById(id);


            if (item.QuantityInShipment < quantity)
                throw new Exception($"Yetersiz stok. Mevcut stok: {item.QuantityInShipment}");

            // Stok yeterliyse işlemleri yap
            _repository.DecreaseStoreStock(id, quantity);
            _repository.DecreaseShipmentStock(id, quantity);
            _repository.AddLog(id, "Sevkiyat tamamlandı", -quantity);

            _repository.Save();
        }


        public void DecreaseShipmentStock(int id, int quantity)
        {
            var item = _repository.GetById(id);



            if (item.QuantityInShipment < quantity)
                throw new Exception($"Yetersiz sevkiyat stoğu. Mevcut: {item.QuantityInShipment}");

            _repository.DecreaseShipmentStock(id, quantity);    
            _repository.Save();

        }
        //public int ReelStock(int id,int quantity) 
        //{ 
        //    _repository.ReduceStockFromStoreAndShipment(id, quantity);
        //    var item=GetItemById(id);
        //    var reelStock=item.QuantityInStore-item.QuantityInShipment;
        //    return reelStock;
        //}

        public void AddLog(int itemId, string actionType,int quantityChanged)
        {
            _repository.AddLog(itemId, actionType, quantityChanged);
        }


    }
}
