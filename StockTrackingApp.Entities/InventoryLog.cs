namespace StokTakip.Entities
{
    public class InventoryLog
    {
        public int Id { get; set; }

        // Hangi üründe işlem yapıldı
        public int InventoryItemId { get; set; }
        public InventoryItem InventoryItem { get; set; }

        // İşlem türü (Ekleme, Çıkarma, Artırma, Azaltma vb.)
        public string ActionType { get; set; }

        // Kaç adet işlem yapıldı
        public int QuantityChanged { get; set; }



        // İşlemin tarihi
        public DateTime ActionDate { get; set; } = DateTime.Now;
    }
}
