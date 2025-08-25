using StockTrackingApp.Business;
using StokTakip.Entities;

namespace StockTrackingApp
{
    public partial class Form1 : Form
    {
        private InventoryManager _manager;
        private int _selectedItemId = -1;
        private int _previousRowIndex = -1; // Önceki seçili satır


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
            // BindingSource ile sarıyoruz ki sıralama çalışsın
            BindingSource bs = new BindingSource();
            bs.DataSource = items;
            dgTablo.DataSource = bs;

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
            dgTablo.Columns["ReelStock"].DisplayIndex = dgTablo.Columns.Count - 1;
            dgTablo.Columns["TotalValue"].HeaderText = "Total Değer";
            dgTablo.Columns["TotalValue"].DisplayIndex = dgTablo.Columns.Count - 1;
            dgTablo.Columns["IsDeleted"].Visible = false;
            dgTablo.Columns["DeletedDate"].Visible = false;

            foreach (DataGridViewColumn col in dgTablo.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.Automatic;
            }

            // DataGridView’e değerleri  


            dgTablo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgTablo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgTablo.DataBindingComplete -= DgTablo_DataBindingComplete; // varsa önceki eventi temizle
            dgTablo.DataBindingComplete += DgTablo_DataBindingComplete;
        }
        private void RefreshAfterAction()
        {
            LoadForm();
            _selectedItemId = -1;
        }

        private void DgTablo_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgTablo.Rows)
            {
                var item = row.DataBoundItem as InventoryItem;
                if (item != null)
                {
                    // Reel stock < 5 ise kırmızı
                    if (item.ReelStock < 5)
                    {
                        row.Cells["ReelStock"].Style.BackColor = Color.LightCoral;
                        row.Cells["ReelStock"].Style.ForeColor = Color.White;
                    }

                    // Ürün grubuna göre renk
                    switch (item.ProductName)
                    {
                        case "Baza":
                            row.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                            break;
                        case "Başlık":
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                            break;
                        case "Yatak":
                            row.DefaultCellStyle.BackColor = Color.LightSkyBlue;
                            break;
                    }

                    // Eğer reel stock kırmızı ise, öncelik onu koru
                    if (item.ReelStock < 5)
                    {
                        row.Cells["ReelStock"].Style.BackColor = Color.LightCoral;
                        row.Cells["ReelStock"].Style.ForeColor = Color.White;
                    }
                }
            }
        }




        private void bMağazaArttır_Click(object sender, EventArgs e)
        {
            if (_selectedItemId > 0 && !string.IsNullOrEmpty(tbMağazaStok.Text)) // önce bir satır seçilmiş mi kontrol et
            {
                var quantity = int.Parse(tbMağazaStok.Text);
                _manager.IncreaseStoreStock(_selectedItemId, quantity);
                RefreshAfterAction();

            }
            else
            {
                MessageBox.Show("Lütfen tablodan bir ürün seçin ve adet kutusunu boş bırakmayın.", "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                ); ;
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
                RefreshAfterAction();
            }
            else
            {
                MessageBox.Show("Lütfen tablodan bir ürün seçin ve adet kutusunu boş bırakmayın.", "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                ); ;
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

                RefreshAfterAction();
            }
            else
            {
                MessageBox.Show("Lütfen tablodan bir ürün seçin ve adet kutusunu boş bırakmayın.", "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                ); ;
            }
            tbSevkiyat.Clear();
        }

        private void bSevkiyatAzalt_Click(object sender, EventArgs e)
        {
            if (_selectedItemId > 0 && !string.IsNullOrEmpty(tbSevkiyat.Text))
            {
                var quantity = int.Parse(tbSevkiyat.Text);
                _manager.DecreaseShipmentStock(_selectedItemId, quantity);
                RefreshAfterAction();
            }
            else
            {
                MessageBox.Show("Lütfen tablodan bir ürün seçin ve adet kutusunu boş bırakmayın.", "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                ); ;
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
                RefreshAfterAction();
            }
            else
            {
                MessageBox.Show("Lütfen tablodan bir ürün seçin ve adet kutusunu boş bırakmayın.");
            }
            tbGuncelle.Clear();
        }

        private void dgTablo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Önceki seçili satırı eski haline döndür
            if (_previousRowIndex >= 0 && _previousRowIndex < dgTablo.Rows.Count)
            {
                var prevRow = dgTablo.Rows[_previousRowIndex];
                var prevItem = prevRow.DataBoundItem as InventoryItem;

                if (prevItem != null)
                {
                    // Grup rengine göre ayarla
                    switch (prevItem.ProductName)
                    {
                        case "Baza":
                            prevRow.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                            prevRow.DefaultCellStyle.ForeColor = Color.Black;
                            break;
                        case "Başlık":
                            prevRow.DefaultCellStyle.BackColor = Color.LightGreen;
                            prevRow.DefaultCellStyle.ForeColor = Color.Black;
                            break;
                        case "Yatak":
                            prevRow.DefaultCellStyle.BackColor = Color.LightSkyBlue;
                            prevRow.DefaultCellStyle.ForeColor = Color.Black;
                            break;
                        default:
                            prevRow.DefaultCellStyle.BackColor = Color.White;
                            prevRow.DefaultCellStyle.ForeColor = Color.Black;
                            break;
                    }

                    // ReelStock < 5 ise, sadece hücre rengini kırmızı yap
                    if (prevItem.ReelStock < 5)
                    {
                        prevRow.Cells["ReelStock"].Style.BackColor = Color.LightCoral;
                        prevRow.Cells["ReelStock"].Style.ForeColor = Color.White;
                    }
                }
            }

            // Şu anki seçili satırı renklendir (her zaman çalışır)
            DataGridViewRow selectedRow = dgTablo.Rows[e.RowIndex];
            selectedRow.DefaultCellStyle.BackColor = Color.Red;
            selectedRow.DefaultCellStyle.ForeColor = Color.White;

            // Seçilen ID'yi güncelle
            _selectedItemId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

            // Önceki indexi güncelle
            _previousRowIndex = e.RowIndex;
        }



        private void bUrunEkle_Click(object sender, EventArgs e)
        {
            AddItemForm addForm = new AddItemForm(_manager);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                // Kaydettikten sonra tabloyu yenile
                RefreshAfterAction();
            }


        }

        private void bUrunSil_Click(object sender, EventArgs e)
        {
            if (_selectedItemId > 0)
            {
                var result = MessageBox.Show("Seçilen ürünü silmek istediğinize emin misiniz?",
                                             "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    _manager.DeleteItem(_selectedItemId);
                    RefreshAfterAction();
                }
            }
            else
            {
                MessageBox.Show("Lütfen tablodan bir ürün seçin ve adet kutusunu boş bırakmayın.", "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                ); ;
            }
        }
    }
}
