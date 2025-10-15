using StockTrackingApp.Business;
using StockTrackingApp.Utils;
using StokTakip.Entities;
using System.Data;
using System.Windows.Forms;

namespace StockTrackingApp
{
    public partial class MainForm : BaseForm
    {
        private InventoryManager _manager;
        private int _selectedItemId = -1;
        private int _previousRowIndex = -1; // Önceki seçili satır

        private BindingSource bs;
        private DataTable dt;

        String urunSecimiMessage = "Lütfen tablodan bir ürün seçin ve adet kutusunu boş bırakmayın.";


        public MainForm(InventoryManager manager)
        {
            InitializeComponent();
            _manager = manager;

            //LoadForm();

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadForm();
            //dgTablo.ClearSelection();
        }

        private void LoadForm()
        {


            var items = _manager.GetAllItems();

            // InventoryItem listesini DataTable'a çevir
            SetupDataTable();

            foreach (var item in items)
            {
                dt.Rows.Add(item.Id, item.ProductName, item.Brand, item.ColorCode,
                    item.Size, item.ReelStock, item.QuantityInShipment,
                    item.QuantityInStore, item.UnitPrice, item.TotalValue,
                    item.IsDeleted, item.DeletedDate);
            }

            // BindingSource kullan
            SetupDataGridView();

            dgTablo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgTablo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            dgTablo.DataBindingComplete -= DgTablo_DataBindingComplete;
            dgTablo.DataBindingComplete += DgTablo_DataBindingComplete;

            ApplyRowStyles();

        }

        private void SetupDataTable()
        {
            dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("ProductName", typeof(string));
            dt.Columns.Add("Brand", typeof(string));
            dt.Columns.Add("ColorCode", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("ReelStock", typeof(int));
            dt.Columns.Add("QuantityInShipment", typeof(int));
            dt.Columns.Add("QuantityInStore", typeof(int));
            dt.Columns.Add("UnitPrice", typeof(decimal));
            dt.Columns.Add("TotalValue", typeof(decimal));
            dt.Columns.Add("IsDeleted", typeof(bool));
            dt.Columns.Add("DeletedDate", typeof(DateTime));
        }

        private void SetupDataGridView()
        {
            bs = new BindingSource();
            bs.DataSource = dt;
            dgTablo.DataSource = bs;

            dgTablo.Columns["Id"].Visible = false;
            dgTablo.Columns["ProductName"].HeaderText = "Ürün Adı";
            dgTablo.Columns["Brand"].HeaderText = "Marka";
            dgTablo.Columns["ColorCode"].HeaderText = "Renk Kodu";
            dgTablo.Columns["Size"].HeaderText = "Ebat";
            dgTablo.Columns["ReelStock"].HeaderText = "Depo";
            dgTablo.Columns["QuantityInShipment"].HeaderText = "Sevkiyatta";
            dgTablo.Columns["QuantityInStore"].HeaderText = "Toplam Stok";
            dgTablo.Columns["UnitPrice"].HeaderText = "Birim Fiyat";
            dgTablo.Columns["TotalValue"].HeaderText = "Total Değer";
            dgTablo.Columns["IsDeleted"].Visible = false;
            dgTablo.Columns["DeletedDate"].Visible = false;

            dgTablo.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Tüm satır seçilsin
            dgTablo.DefaultCellStyle.SelectionBackColor = Color.Red;         // Seçili satırın arka planı
            dgTablo.DefaultCellStyle.SelectionForeColor = Color.White;

            dgTablo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgTablo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void ApplyFilter()
        {
            if (bs == null) return;

            List<string> filters = new List<string>();

            if (!string.IsNullOrEmpty(tbUrunAdi.Text))
                filters.Add($"ProductName LIKE '%{tbUrunAdi.Text.Replace("'", "''")}%'");

            if (!string.IsNullOrEmpty(tbMarka.Text))
                filters.Add($"Brand LIKE '%{tbMarka.Text.Replace("'", "''")}%'");

            if (!string.IsNullOrEmpty(tbRenkKodu.Text))
                filters.Add($"ColorCode LIKE '%{tbRenkKodu.Text.Replace("'", "''")}%'");

            if (!string.IsNullOrEmpty(tbEbat.Text))
                filters.Add($"Size LIKE '%{tbEbat.Text.Replace("'", "''")}%'");

            bs.Filter = string.Join(" AND ", filters);

            // Filtre sonrası renkleri tekrar uygula
            DgTablo_DataBindingComplete(null, null);
        }




        private void RefreshAfterAction()
        {
            LoadForm();
            //ApplyRowStyles();
            //dgTablo.ClearSelection();
            //dgTablo.Refresh();
            _selectedItemId = -1;
        }

        private void DgTablo_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ApplyRowStyles();

        }

        private void ApplyRowStyles()
        {
            foreach (DataGridViewRow row in dgTablo.Rows)
            {
                if (row.DataBoundItem is DataRowView drv)
                {
                    string productName = drv["ProductName"].ToString();
                    int reelStock = Convert.ToInt32(drv["ReelStock"]);

                    // Satır seçili değilse grup rengine göre ayarla
                    if (row.Index != _previousRowIndex)
                    {
                        switch (productName)
                        {
                            case "Baza":
                                row.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                                row.DefaultCellStyle.ForeColor = Color.Black;
                                break;
                            case "Başlık":
                                row.DefaultCellStyle.BackColor = Color.LightGreen;
                                row.DefaultCellStyle.ForeColor = Color.Black;
                                break;
                            case "Yatak":
                                row.DefaultCellStyle.BackColor = Color.LightSkyBlue;
                                row.DefaultCellStyle.ForeColor = Color.Black;
                                break;
                            default:
                                row.DefaultCellStyle.BackColor = Color.White;
                                row.DefaultCellStyle.ForeColor = Color.Black;
                                break;
                        }
                    }

                    // ReelStock < 5 ise sadece hücreyi kırmızı yap
                    if (reelStock < 5)
                    {
                        row.Cells["ReelStock"].Style.BackColor = Color.LightCoral;
                        row.Cells["ReelStock"].Style.ForeColor = Color.White;
                    }
                }
            }
        }



        private void dgTablo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) {
                
                return;
            }
            

            _previousRowIndex = e.RowIndex;

            // Seçilen ID'yi güncelle
            var value = dgTablo.Rows[e.RowIndex].Cells["Id"].Value;

            if (value != null && value != DBNull.Value)
            {
                _selectedItemId = Convert.ToInt32(value);
            }
            else
            {
                _selectedItemId = 0; // boş değer atanıyor
            }



            // Renkleri tekrar uygula
            DgTablo_DataBindingComplete(null, null);
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
        private void bMağazaArttır_Click(object sender, EventArgs e)
        {
            if (_selectedItemId > 0 && !string.IsNullOrEmpty(tbMağazaStok.Text)) // önce bir satır seçilmiş mi kontrol et
            {
                var quantity = int.Parse(tbMağazaStok.Text);
                _manager.IncreaseStoreStock(_selectedItemId, quantity);


                MessageHelper.ShowInfo("Mağaza stoğu başarıyla arttırıldı.");
                RefreshAfterAction();

            }
            else
            {
                MessageHelper.ShowWarning(urunSecimiMessage);
            }

            tbMağazaStok.Clear();

        }
        private void bMağazaAzalt_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedItemId > 0 && !string.IsNullOrEmpty(tbMağazaStok.Text))
                {
                    var quantity = int.Parse(tbMağazaStok.Text);
                    _manager.DecreaseStoreStock(_selectedItemId, quantity);
                    RefreshAfterAction();
                    MessageHelper.ShowInfo("Mağaza stoğu başarıyla azaltıldı.");
                }
                else
                {
                    MessageHelper.ShowWarning(urunSecimiMessage);
                }
                tbMağazaStok.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bSevkiyatArttır_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedItemId > 0 && !string.IsNullOrEmpty(tbSevkiyat.Text))
                {
                    var quantity = int.Parse(tbSevkiyat.Text);
                    _manager.IncreaseShipmentStock(_selectedItemId, quantity);

                    MessageHelper.ShowInfo("Sevkiyata sevk edildi");
                    RefreshAfterAction();
                }
                else
                {
                    MessageHelper.ShowWarning(urunSecimiMessage);
                }
                tbSevkiyat.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSevkiyat.Clear();

            }
        }


        private void bSevkiyatAzalt_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedItemId > 0 && !string.IsNullOrEmpty(tbSevkiyat.Text))
                {
                    var quantity = int.Parse(tbSevkiyat.Text);
                    _manager.DecreaseShipmentStock(_selectedItemId, quantity);

                    MessageHelper.ShowInfo("Sevkiyat stoğu başarıyla azaltıldı.");
                    RefreshAfterAction();
                }
                else
                {
                    MessageHelper.ShowWarning(urunSecimiMessage);
                }
                tbSevkiyat.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbMağazaStok.Clear();

            }
        }

        private void bGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedItemId > 0 && !string.IsNullOrEmpty(tbGuncelle.Text))
                {
                    var quantity = int.Parse(tbGuncelle.Text);
                    _manager.CompleteOrder(_selectedItemId, quantity);
                    MessageHelper.ShowInfo("Sevkiyat Tamamlandı");
                    RefreshAfterAction();
                }
                else
                {
                    MessageHelper.ShowWarning(urunSecimiMessage);
                }
                tbGuncelle.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbMağazaStok.Clear();

            }
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
                var result = MessageHelper.ShowConfirm("Seçilen ürünü silmek istediğinize emin misiniz?");
                if (result == DialogResult.Yes)
                {
                    _manager.DeleteItem(_selectedItemId);
                    RefreshAfterAction();
                    MessageHelper.ShowInfo("Ürün silindi.");
                }
            }
            else
            {
                MessageHelper.ShowWarning(urunSecimiMessage);

            }
        }



        private void bRapor_Click(object sender, EventArgs e)
        {
            ReportForm logForm = new ReportForm();
            if (logForm.ShowDialog() == DialogResult.OK)
            {
                // Kaydettikten sonra tabloyu yenile
                RefreshAfterAction();
            }
        }


        private void tbUrunAdi_TextChanged(object sender, EventArgs e) => ApplyFilter();
        private void tbMarka_TextChanged(object sender, EventArgs e) => ApplyFilter();
        private void tbRenkKodu_TextChanged(object sender, EventArgs e) => ApplyFilter();
        private void tbEbat_TextChanged(object sender, EventArgs e) => ApplyFilter();

        private void bTemizle_Click(object sender, EventArgs e)
        {
            tbUrunAdi.Clear();
            tbMarka.Clear();
            tbRenkKodu.Clear();
            tbEbat.Clear();
        }

        private void bGuncelle_Click(object sender, EventArgs e)
        {

            if (_selectedItemId > 0)
            {
                UpdateForm updateForm = new UpdateForm(_manager, _selectedItemId);
                if (updateForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshAfterAction();
                }
            }
            else
            {
                MessageHelper.ShowWarning("Lütfen güncellenecek bir ürün seçin.");
            }
        }


        private void bExcel_Click(object sender, EventArgs e)
        {

            ExcelExporter.ExportDataGridViewToExcel(dgTablo);
        }
    
    }
}

