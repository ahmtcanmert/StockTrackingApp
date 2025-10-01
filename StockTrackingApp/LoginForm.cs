using StockTrackingApp.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTrackingApp
{
    public partial class LoginForm : Form
    {
        private InventoryManager _manager;

        public LoginForm(InventoryManager manager)
        {
            _manager = manager;
            InitializeComponent();
        }
        private bool AreTextBoxesFilled(params TextBox[] textBoxes)
        {
            foreach (var tb in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(tb.Text)) // boş ya da sadece space ise
                {
                    return false;
                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!AreTextBoxesFilled(tbName, tbPassword))
            {
                MessageBox.Show(
                    "Lütfen tüm alanları doldurun!",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            if (tbName.Text.Equals("a") && tbPassword.Text.Equals("12"))
            {
                this.DialogResult = DialogResult.OK;    // ana formu aç
                this.Close();

            }
            else MessageBox.Show(
                    "Hatalı kullanıcı adı veya şifre girdiniz",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
        }

        private void Çıkış_Click(object sender, EventArgs e)
        {

        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
