using StockTrackingApp.Business;
using StokTakip.Entities;

namespace StockTrackingApp
{
    public partial class Form1 : Form
    {
        private InventoryManager _manager;
        private int _selectedItemId = -1;

        public Form1(InventoryManager manager)
        {
            InitializeComponent();
            _manager = manager;
            LoadForm();
        }

        private void LoadForm()
        {
            dgTablo.DataSource = null;

            // Tüm ürünleri getir
            var items = _manager.GetAllItems();

            // DataGridView'e ata
            dgTablo.DataSource = items;

            // Kolon ayarları
            dgTablo.Columns["Id"].Visible = false;
            dgTablo.Columns["ProductName"].HeaderText = "Ürün Adı";
            dgTablo.Columns["Brand"].HeaderText = "Marka";
            dgTablo.Columns["ColorCode"].HeaderText = "Renk Kodu";
            dgTablo.Columns["Size"].HeaderText = "Ebat";
            dgTablo.Columns["QuantityInStore"].HeaderText = "Mağaza Stok";
            dgTablo.Columns["QuantityInShipment"].HeaderText = "Sevkiyat Stok";
            dgTablo.Columns["UnitPrice"].HeaderText = "Birim Fiyat";
            dgTablo.Columns["ReelStock"].HeaderText = "Reel Stok";
            dgTablo.Columns["ReelStock"].DisplayIndex=dgTablo.Columns.Count-1;
            dgTablo.Columns["TotalValue"].HeaderText = "Total Değer";
            dgTablo.Columns["TotalValue"].DisplayIndex = dgTablo.Columns.Count-1;
            dgTablo.Columns["IsDeleted"].Visible=false;
            dgTablo.Columns["DeletedDate"].Visible=false;
            // ReelStock ve TotalValue en sona gelsin
            //if (!dgTablo.Columns.Contains("ReelStock"))
            //{
            //    dgTablo.Columns.Add(new DataGridViewTextBoxColumn
            //    {
            //        Name = "ReelStock",
            //        HeaderText = "Reel Stok",
            //        ReadOnly = true,
            //        DisplayIndex = dgTablo.Columns.Count // en sona
            //    });
            //}

            //if (!dgTablo.Columns.Contains("TotalValue"))
            //{
            //    dgTablo.Columns.Add(new DataGridViewTextBoxColumn
            //    {
            //        Name = "TotalValue",
            //        HeaderText = "Total Değer",
            //        ReadOnly = true,
            //        DisplayIndex = dgTablo.Columns.Count // en sona
            //    });
            //}

            // DataGridView’e değerleri ata
            foreach (DataGridViewRow row in dgTablo.Rows)
            {
                
                var item = row.DataBoundItem as InventoryItem;
             
                    //row.Cells["ReelStock"].Value = item.ReelStock;
                    //row.Cells["TotalValue"].Value = item.TotalValue;

                    if ((item.ReelStock < 5))// stok azsa
                    {
                    row.Cells["ReelStock"].Style.BackColor = Color.LightCoral; // arka plan kırmızımsı
                        row.Cells["ReelStock"].Style.ForeColor = Color.White; // yazı beyaz
                    }
                
    

            }

            dgTablo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgTablo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }





        private void bMağazaArttır_Click(object sender, EventArgs e)
        {
            if (_selectedItemId > 0 && !string.IsNullOrEmpty(tbMağazaStok.Text)) // önce bir satır seçilmiş mi kontrol et
            {
                var quantity = int.Parse(tbMağazaStok.Text);
                _manager.IncreaseStoreStock(_selectedItemId, quantity);
                LoadForm();
            }
            else
            {
                MessageBox.Show("Lütfen tablodan bir ürün seçin ve adet kutusunu boş bırakmayın.");
            }
            tbMağazaStok.Clear();
        }

        private void tbMağazaStokArttır_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void tbSevkiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbGuncelle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bMağazaAzalt_Click(object sender, EventArgs e)
        {
            if (_selectedItemId > 0 && !string.IsNullOrEmpty(tbMağazaStok.Text))
            {
                var quantity = int.Parse(tbMağazaStok.Text);
                _manager.DecreaseStoreStock(_selectedItemId, quantity);
                LoadForm();
            }
            else
            {
                MessageBox.Show("Lütfen tablodan bir ürün seçin ve adet kutusunu boş bırakmayın.");
            }
            tbMağazaStok.Clear();
        }

        private void bSevkiyatArttır_Click(object sender, EventArgs e)
        {
            if (_selectedItemId > 0 && !string.IsNullOrEmpty(tbSevkiyat.Text))
            {
                var quantity = int.Parse(tbSevkiyat.Text);
                _manager.IncreaseShipmentStock(_selectedItemId, quantity);
                _manager.DecreaseStoreStock(_selectedItemId, quantity);

                LoadForm();
            }
            else
            {
                MessageBox.Show("Lütfen tablodan bir ürün seçin ve adet kutusunu boş bırakmayın.");
            }
            tbSevkiyat.Clear();
        }

        private void bSevkiyatAzalt_Click(object sender, EventArgs e)
        {
            if (_selectedItemId > 0 && !string.IsNullOrEmpty(tbSevkiyat.Text))
            {
                var quantity = int.Parse(tbSevkiyat.Text);
                _manager.DecreaseShipmentStock(_selectedItemId, quantity);
                LoadForm();
            }
            else
            {
                MessageBox.Show("Lütfen tablodan bir ürün seçin ve adet kutusunu boş bırakmayın.");
            }
            tbSevkiyat.Clear();
        }

        private void bGüncelle_Click(object sender, EventArgs e)
        {
            if (_selectedItemId > 0 && !string.IsNullOrEmpty(tbGuncelle.Text))
            {
                var quantity = int.Parse(tbGuncelle.Text);
                _manager.DecreaseStoreStock(_selectedItemId, quantity);
                _manager.DecreaseShipmentStock(_selectedItemId, quantity);
                LoadForm();
            }
            else
            {
                MessageBox.Show("Lütfen tablodan bir ürün seçin ve adet kutusunu boş bırakmayın.");
            }
            tbGuncelle.Clear();
        }

        private void dgTablo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgTablo.Rows[e.RowIndex];
                _selectedItemId = Convert.ToInt32(row.Cells["Id"].Value);

                Console.WriteLine("Seçilen Id: " + _selectedItemId);
            }
        }

        private void bUrunEkle_Click(object sender, EventArgs e)
        {
            AddItemForm addForm = new AddItemForm(_manager);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                // Kaydettikten sonra tabloyu yenile
                LoadForm();
            }


        }
    }
}
