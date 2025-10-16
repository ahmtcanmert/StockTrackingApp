using System;
using System.Drawing;
using System.Windows.Forms;

namespace StockTrackingApp
{
    public class BaseForm : Form
    {
        public BaseForm()
        {
            // Ortak başlangıç ayarları
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.StartPosition = FormStartPosition.CenterScreen;



            // Ekran boyutunu otomatik ayarla (örnek)
            SetDefaultSize();
        }

        protected virtual void SetDefaultSize()
        {
            // Örnek: ekranın %80'ini kaplasın
            var screen = Screen.PrimaryScreen.WorkingArea;
            this.Size = new Size((int)(screen.Width * 0.9), (int)(screen.Height * 0.9));
        }


    }
}
