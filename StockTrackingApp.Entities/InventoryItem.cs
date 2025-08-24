namespace StokTakip.Entities
{
    public class InventoryItem
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public string ColorCode { get; set; }
        public string Size { get; set; }
        public int QuantityInStore { get; set; }
        public int QuantityInShipment { get; set; }
        public decimal UnitPrice { get; set; }

        // Yeni kolonlar
        public bool IsDeleted { get; set; } = false; // default aktif
        public DateTime? DeletedDate { get; set; }   // ne zaman silindiği

        // Reel stok her zaman mağaza - sevkiyat
        public int ReelStock => Math.Max(QuantityInStore - QuantityInShipment, 0);

        // Total değer: birim fiyat * reel stok
        public decimal TotalValue => UnitPrice * ReelStock;
    }
}
