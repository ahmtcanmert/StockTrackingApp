using StockTrackingApp.DataAccess;
using StockTrackingApp.Entities.DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace StockTrackingApp
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void LogForm_Load(object sender, EventArgs e)
        {
            LoadYearComboBox();
            LoadMonthComboBox();

            LoadReport(DateTime.Now.Year); // DataGridView yükle
        }

        private void LoadYearComboBox()
        {
            cmbYear.Items.Clear();

            var repo = new InventoryLogRepository();
            var years = repo.GetAllYears(); // Bu metodu repo’ya ekleyelim

            foreach (var y in years)
                cmbYear.Items.Add(y);

            if (cmbYear.Items.Count > 0)
                cmbYear.SelectedIndex = 0;
        }
        private void LoadReportByYear(int selectedYear)
        {
            var repo = new InventoryLogRepository();
            var data = repo.GetYearlyChanges(selectedYear);

            dgvReport.DataSource = data;

            dgvReport.Columns["ProductName"].HeaderText = "Ürün Adı";
            dgvReport.Columns["Brand"].HeaderText = "Marka";
            dgvReport.Columns["ColorCode"].HeaderText = "Renk Kodu";
            dgvReport.Columns["Year"].HeaderText = "Yıl";
            dgvReport.Columns["Incoming"].HeaderText = "Gelen Ürün";
            dgvReport.Columns["Outgoing"].HeaderText = "Çıkan Ürün";
        }
        private void LoadMonthComboBox()
        {
            cmbMonth.Items.Clear();
            var months = new[]
            {
                new { Text = "---", Value = 0 },
                new { Text = "Ocak", Value = 1 },
                new { Text = "Şubat", Value = 2 },
                new { Text = "Mart", Value = 3 },
                new { Text = "Nisan", Value = 4 },
                new { Text = "Mayıs", Value = 5 },
                new { Text = "Haziran", Value = 6 },
                new { Text = "Temmuz", Value = 7 },
                new { Text = "Ağustos", Value = 8 },
                new { Text = "Eylül", Value = 9 },
                new { Text = "Ekim", Value = 10 },
                new { Text = "Kasım", Value = 11 },
                new { Text = "Aralık", Value = 12 }
            };

            cmbMonth.DisplayMember = "Text";
            cmbMonth.ValueMember = "Value";

            foreach (var m in months)
                cmbMonth.Items.Add(m);

            cmbMonth.SelectedIndex = DateTime.Now.Month - 1;
        }

        private void LoadReport(int? year = null, int? month = null)
        {
            var repo = new InventoryLogRepository();
            List<ChangeDto> data;

            if (month.HasValue && month.Value != 0) // Ay seçilmişse
            {
                data = repo.GetMonthlyChanges(year, month);
               // dgvReport.Columns["Month"].Visible = true;
            }
            else if (year.HasValue) // "---" yani ay seçilmemişse
            {
                data = repo.GetYearlyChanges(year.Value);
                //dgvReport.Columns["Month"].Visible = false;
            }
            else
            {
                data = new List<ChangeDto>();
            }

            dgvReport.DataSource = data;

            dgvReport.Columns["ProductName"].HeaderText = "Ürün Adı";
            dgvReport.Columns["Brand"].HeaderText = "Marka";
            dgvReport.Columns["ColorCode"].HeaderText = "Renk Kodu";
            dgvReport.Columns["Year"].HeaderText = "Yıl";
            dgvReport.Columns["Month"].HeaderText = "Ay";
            dgvReport.Columns["Incoming"].HeaderText = "Giriş";
            dgvReport.Columns["Outgoing"].HeaderText = "Çıkış";

            SetColumnOrder();
        }


        private void SetColumnOrder()
        {
            int index = 0;
            dgvReport.Columns["ProductName"].DisplayIndex = index++;
            dgvReport.Columns["Brand"].DisplayIndex = index++;
            dgvReport.Columns["ColorCode"].DisplayIndex = index++;
            dgvReport.Columns["Year"].DisplayIndex = index++;
            dgvReport.Columns["Month"].DisplayIndex = index++;
            dgvReport.Columns["ChangeAmount"].DisplayIndex = index++;
        }

        private void bFiltre_Click(object sender, EventArgs e)
        {
            int? selectedYear = cmbYear.SelectedItem != null ? (int?)cmbYear.SelectedItem : null;
            int? selectedMonth = cmbMonth.SelectedItem != null ? (int?)((dynamic)cmbMonth.SelectedItem).Value : null;

            LoadReport(selectedYear, selectedMonth);
        }
    }
}
