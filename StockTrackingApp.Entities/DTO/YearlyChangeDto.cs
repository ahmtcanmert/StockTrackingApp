using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingApp.Entities.DTO
{
    public class YearlyChangeDto
    {
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public string ColorCode { get; set; }
        public int Year { get; set; }
        public int Incoming { get; set; }  // Pozitif değişimler
        public int Outgoing { get; set; }  // Negatif değişimler
    }

}
