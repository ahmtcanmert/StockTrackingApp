using StockTrackingApp.Business;
using StockTrackingApp.Businiess.Contracts;
using StockTrackingApp.Entities.DTO;
using StockTrackingApp.Utils;
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
    public partial class UpdateForm : Form
    {
        private readonly IServiceManager _manager;
        private readonly int _itemId;

        public UpdateForm(IServiceManager manager, int itemId)
        {
            InitializeComponent();
            _manager = manager;
            _itemId = itemId;
        }
        private void UpdateForm_Load(object sender, EventArgs e)
        {
            var item = _manager.InventoryService.GetItemById(_itemId);
            tbUrunAdi.Text = item.ProductName;
            tbMarka.Text = item.Brand;
            tbRenkKodu.Text = item.ColorCode;
            tbEbat.Text = item.Size;
            tbFiyat.Text = item.UnitPrice.ToString();
            // diğer textbox’lara setle
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            var item = _manager.InventoryService.GetItemById(_itemId);
            var dto = new UpdateInventoryItemDto
            {
                Id = _itemId,
                ProductName = tbUrunAdi.Text,
                Brand = tbMarka.Text,
                ColorCode = tbRenkKodu.Text,
                Size = tbEbat.Text,
                UnitPrice = Convert.ToDecimal(tbFiyat.Text)
            };

            _manager.InventoryService.UpdateItem(dto);
            this.DialogResult = DialogResult.OK;
            MessageHelper.ShowInfo("Başarılı");
            this.Close();
        }


        private void tbFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
    }
}
