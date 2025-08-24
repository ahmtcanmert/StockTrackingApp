using StockTrackingApp.Business;
using StokTakip.Entities;
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
    public partial class AddItemForm : Form
    {
        private InventoryManager _manager;
        public AddItemForm(InventoryManager manager)
        {
            InitializeComponent();
            _manager = manager;

        }

        private void bUrunEkle_Click(object sender, EventArgs e)
        {
            try
            {
                string productName = tbUrunAdi.Text.Trim();
                string brand = tbMarka.Text.Trim();
                string colorCode = tbRenkKodu.Text.Trim();
                string size = tbEbat.Text.Trim();
                decimal unitPrice = decimal.Parse(tbFiyat.Text.Trim());
                int quantityInStore = 0; //int.Parse(tbMağazaStok.Text.Trim());
                int quantityInShipment = 0; // int.Parse(tbSevkiyatStok.Text.Trim());

                // Yeni InventoryItem oluştur
                InventoryItem newItem = new InventoryItem
                {
                    ProductName = productName,
                    Brand = brand,
                    ColorCode = colorCode,
                    Size = size,
                    UnitPrice = unitPrice,
                    QuantityInStore = quantityInStore,
                    QuantityInShipment = quantityInShipment
                };

                // Manager üzerinden ekle
                _manager.AddItem(newItem);
                clearTextBox();
                MessageBox.Show("Ürün başarıyla eklendi!");
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }

        }
        public void clearTextBox()
        {
            tbUrunAdi.Clear();
            tbMarka.Clear();
            tbRenkKodu.Clear();
            tbEbat.Clear();
            tbFiyat.Clear();
            // tbMağazaStok.Clear();
            // tbSevkiyatStok.Clear();
        }

        private void tbEbat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
     && !char.IsDigit(e.KeyChar)
     && (e.KeyChar != 'x'))
            {
                e.Handled = true;
            }

            // Birden fazla nokta olmasını engelle
            if ((e.KeyChar == 'x') && ((sender as TextBox).Text.IndexOf('x') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbFiyat_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
     && !char.IsDigit(e.KeyChar)
     && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Birden fazla nokta olmasını engelle
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
