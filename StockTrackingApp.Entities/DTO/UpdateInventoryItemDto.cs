using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingApp.Entities.DTO
{
    public class UpdateInventoryItemDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public string ColorCode { get; set; }
        public string Size { get; set; }
        public int QuantityInStore { get; set; }
        public int QuantityInShipment { get; set; }
        public decimal UnitPrice { get; set; }
    }


}
