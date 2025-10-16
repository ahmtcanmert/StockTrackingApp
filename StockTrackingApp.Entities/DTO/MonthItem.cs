using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingApp.Entities.DTO
{
    public class MonthItem
    {
        public string Text { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return Text; // ComboBox'da gözükecek değer
        }
    }

}
