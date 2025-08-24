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
            _context.Database.EnsureCreated(); // Veritabanını oluşturur (Migration gerektirmez)
        }

        public List<InventoryItem> GetAll() => _context.InventoryItems.ToList();
        public InventoryItem GetById(int id) => _context.InventoryItems.Find(id);
        public void Add(InventoryItem item) => _context.InventoryItems.Add(item);
        public void Update(InventoryItem item) => _context.InventoryItems.Update(item);
        public void Delete(int id)
        {
            var item = _context.InventoryItems.Find(id);
            if (item != null) _context.InventoryItems.Remove(item);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        public void IncreaseStoreStock(int id, int quantity)
        {
            var item = _context.InventoryItems.Find(id);
            if (item != null)
            {
                item.QuantityInStore += quantity;
                _context.SaveChanges();
            }
        }

        // 📉 Mağaza stok azaltma
        public void DecreaseStoreStock(int id, int quantity)
        {
            var item = _context.InventoryItems.Find(id);
            if (item != null && item.QuantityInStore >= quantity && item.ReelStock >= quantity)
            {
                item.QuantityInStore -= quantity;
                _context.SaveChanges();
            }
        }

        // 🚚 Sevkiyat stok artırma
        public void IncreaseShipmentStock(int id, int quantity)
        {
            var item = _context.InventoryItems.Find(id);
            var reelStock = item.ReelStock;
            if (item != null && reelStock >= quantity)
            {
                item.QuantityInShipment += quantity;
                _context.SaveChanges();
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
            }
        }
        public int ReelStock(int id)
        {
            var item = _context.InventoryItems.Find(id);
            if (item != null) 
            {
                var reelStock=item.QuantityInStore - item.QuantityInShipment;
                return reelStock;
            }
            return -1;
            
        }

        public void ReduceStockFromStoreAndShipment(int id, int quantity)
        {
            var item = _context.InventoryItems.Find(id);
            if (item == null)
            {
                Console.WriteLine("Ürün bulunamadı.");
                return;
            }

            if (item.QuantityInStore < quantity || item.QuantityInShipment < quantity)
            {
                Console.WriteLine("Yeterli stok yok!");
                return;
            }

            item.QuantityInStore -= quantity;
            item.QuantityInShipment -= quantity;

            Console.WriteLine($"{item.ProductName} - {item.Brand} stokları güncellendi. " +
                              $"Mağaza: {item.QuantityInStore}, Sevkiyat: {item.QuantityInShipment}");
        }


    }
}