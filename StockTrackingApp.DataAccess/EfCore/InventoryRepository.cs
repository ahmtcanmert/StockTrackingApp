using StockTrackingApp.Entities.DTO;
using StokTakip.DataAccess;
using StokTakip.Entities;
using StokTakip.Entities.Repository;
using System.Collections.Generic;
using System.Linq;

namespace StockTrackingApp.DataAccess
{
    public class InventoryRepository : IInventoryRepository
    {
        private readonly InventoryContext _context;

        public InventoryRepository()
        {
            _context = new InventoryContext();
            _context.Database.EnsureCreated(); // Migration olmadan DB açar
        }

        public List<InventoryItem> GetAll() => _context.InventoryItems.ToList();

        public InventoryItem GetById(int id) => _context.InventoryItems.Find(id);

        public void Add(InventoryItem item)
        {
            _context.InventoryItems.Add(item);
            _context.SaveChanges();

            AddLog(item.Id, "Ekleme", item.QuantityInStore, item.QuantityInShipment, 0);
        }

        public void Update(UpdateInventoryItemDto dto)
        {
            var existing = _context.InventoryItems.FirstOrDefault(x => x.Id == dto.Id);

            if (existing == null)
                throw new InvalidOperationException("Ürün bulunamadı.");

            // Manuel mapping
            existing.ProductName = dto.ProductName;
            existing.Brand = dto.Brand;
            existing.ColorCode = dto.ColorCode;
            existing.Size = dto.Size;
            existing.QuantityInStore = dto.QuantityInStore;
            existing.QuantityInShipment = dto.QuantityInShipment;
            existing.UnitPrice = dto.UnitPrice;

            _context.SaveChanges();


        }

        public void Delete(int id)
        {
            var item = _context.InventoryItems.Find(id);
            if (item != null)
            {
                _context.InventoryItems.Remove(item);
                _context.SaveChanges();

                AddLog(item.Id, "Ürün Silindi", 0, 0, 0);
            }
        }

        public void Save() => _context.SaveChanges();

        // 📈 Mağaza stok artırma
        public void IncreaseStoreStock(int id, int quantity)
        {
            var item = _context.InventoryItems.Find(id);
            if (item != null)
            {
                item.QuantityInStore += quantity;
                _context.SaveChanges();

                AddLog(item.Id, "Ekleme", item.QuantityInStore, item.QuantityInShipment, quantity);
            }
        }

        // 📉 Mağaza stok azaltma
        public void DecreaseStoreStock(int id, int quantity)
        {
            var item = _context.InventoryItems.Find(id);
            if (item != null && item.QuantityInStore >= quantity)
            {
                item.QuantityInStore -= quantity;
                _context.SaveChanges();

                AddLog(item.Id, "Çıkarma", item.QuantityInStore, item.QuantityInShipment, -quantity);
            }
        }

        // 🚚 Sevkiyat stok artırma
        public void IncreaseShipmentStock(int id, int quantity)
        {
            var item = _context.InventoryItems.Find(id);
            if (item != null && item.ReelStock >= quantity)
            {
                item.QuantityInShipment += quantity;
                _context.SaveChanges();

                AddLog(item.Id, "Ekleme", item.QuantityInStore, item.QuantityInShipment, quantity);
            }
        }

        // 🚫 Sevkiyat stok azaltma
        public void DecreaseShipmentStock(int id, int quantity)
        {
            var item = _context.InventoryItems.Find(id);
            if (item != null && item.QuantityInShipment >= quantity)
            {
                item.QuantityInShipment -= quantity;
                _context.SaveChanges();

                AddLog(item.Id, "Çıkarma", item.QuantityInStore, item.QuantityInShipment, -quantity);
            }
        }

        // 📉 Hem mağaza hem sevkiyat stok azaltma
        public void ReduceStockFromStoreAndShipment(int id, int quantity)
        {
            var item = _context.InventoryItems.Find(id);
            if (item == null) return;

            if (item.QuantityInStore < quantity || item.QuantityInShipment < quantity)
            {
                Console.WriteLine("Yeterli stok yok!");
                return;
            }

            item.QuantityInStore -= quantity;
            item.QuantityInShipment -= quantity;
            _context.SaveChanges();

            AddLog(item.Id, "Çıkarma", item.QuantityInStore, item.QuantityInShipment, -quantity);
        }

        public int ReelStock(int id)
        {
            var item = _context.InventoryItems.Find(id);
            return item != null ? item.QuantityInStore - item.QuantityInShipment : -1;
        }

        // ❌ Soft delete
        public void SoftDelete(int id)
        {
            var item = _context.InventoryItems.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                item.IsDeleted = true;
                item.DeletedDate = DateTime.Now;
                _context.SaveChanges();

                AddLog(item.Id, "Ürün Soft Delete", item.QuantityInStore, item.QuantityInShipment, 0);
            }
        }

        // 🔑 Log ekleme helper metodu
        private void AddLog(int itemId, string actionType, int storeAfter, int shipmentAfter, int quantityChanged)
        {
            var log = new InventoryLog
            {
                InventoryItemId = itemId,
                ActionType = actionType,
                QuantityChanged = quantityChanged,
                ActionDate = DateTime.Now //(2024, 6, 15, 12, 0, 0)
            };

            _context.InventoryLogs.Add(log);
            _context.SaveChanges();
        }
    }
}
