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
        public int? Month { get; set; }

        // Gelen ve çıkan ürünleri ayrı ayrı tutuyoruz
        public int Incoming { get; set; }
        public int Outgoing { get; set; }

        public string ActionType { get; set; } // isteğe bağlı, rapor detayları için
    }



}
