using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingApp.Entities.DTO
{
    public class MonthlyChangeDto
    {
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public string ColorCode { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int ChangeAmount { get; set; }

        // İsteğe bağlı: Ay ismini direkt göstermek için
        public string MonthName => new DateTime(Year, Month, 1).ToString("MMMM");

        public int Incoming { get; set; }    // Ürün gelen
        public int Outgoing { get; set; }
    }


}
