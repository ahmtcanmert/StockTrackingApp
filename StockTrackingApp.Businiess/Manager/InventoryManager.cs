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
            _repository.Delete(id);
            _repository.Save();
        }

        public string DecreaseStock(int id, int quantity)
        {
            throw new NotImplementedException();
        }

        public void IncreaseStock(int id, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
