using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingApp.Entities.DTO
{
    public class ChangeDto
    {
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public string ColorCode { get; set; }
        public int Year { get; set; }
        public int? Month { get; set; } // yıl bazlı raporda null olur

        public int QuantityChanged { get; set; }



    }

}
