using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingApp.Utils
{
    public static class MessageHelper
    {
        public static void ShowWarning(string message, string title = "Uyarı")
        {
            MessageBox.Show(message, title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        public static void ShowError(string message, string title = "Hata")
        {
            MessageBox.Show(message, title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        public static void ShowInfo(string message, string title = "Bilgi")
        {
            MessageBox.Show(message, title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public static DialogResult ShowConfirm(string message, string title = "Onay")
        {

            return MessageBox.Show(message, title,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
        }
    }

}
