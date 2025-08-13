using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Entities
{
    public class InventoryItem
    {
        public int Id { get; set; }

        public string ProductName { get; set; }
        public string Brand { get; set; }
        public string ColorCode { get; set; }
        public string Model { get; set; }
        public string Size { get; set; }
        public decimal UnitPrice { get; set; }

        // Mağazada bulunan adet
        public int QuantityInStore { get; set; }

        // Sevkiyatta olan adet
        public int QuantityInShipment { get; set; }
    }

} 