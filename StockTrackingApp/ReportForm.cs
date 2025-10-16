using DocumentFormat.OpenXml.Office2013.Excel;
using StockTrackingApp.Businiess.Contracts;
using StockTrackingApp.Entities.DTO;
using StockTrackingApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StockTrackingApp
{
    public partial class ReportForm : Form
    {
        private readonly IServiceManager _manager;

        public ReportForm(IServiceManager manager)
        {
            InitializeComponent();
            _manager = manager;

            // DataGridView CellFormatting eventini bağla
            dgvReport.CellFormatting += DgvReport_CellFormatting;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            // Eski logları temizle (4 aydan eski)
            _manager.InventoryLogService.ClearOldLogs(4);

            // Ay ComboBox'ını yükle (son 4 ay)
            LoadMonthComboBox();

            // Raporu yükle
            LoadReport();
        }

        private void LoadMonthComboBox()
        {
            cmbMonth.Items.Clear();

            var today = DateTime.Today;

            var last4Months = Enumerable.Range(0, 4)
                .Select(i => today.AddMonths(-i))
                .OrderByDescending(d => d)
                .ToList();

            foreach (var date in last4Months)
            {
                cmbMonth.Items.Add(new MonthItem
                {
                    Text = date.ToString("MMMM yyyy"),
                    Month = date.Month,
                    Year = date.Year
                });
            }

            if (cmbMonth.Items.Count > 0)
                cmbMonth.SelectedIndex = 0;

            cmbMonth.SelectedIndexChanged += (s, e) => LoadReport(); // ComboBox değişince filtrele
        }

        private void LoadReport()
        {
            if (cmbMonth.SelectedItem == null)
                return;

            var selected = (MonthItem)cmbMonth.SelectedItem;
            int month = selected.Month;
            int year = selected.Year;

            // Son 4 ay verilerini al
            var data = _manager.InventoryLogService.GetAllLogs()
                .Where(l => l.Month == month && l.Year == year)
                .ToList();

            dgvReport.DataSource = data;

            SetGridHeaders();
        }

        private void SetGridHeaders()
        {
            dgvReport.Columns["ProductName"].HeaderText = "Ürün Adı";
            dgvReport.Columns["Brand"].HeaderText = "Marka";
            dgvReport.Columns["ColorCode"].HeaderText = "Renk Kodu";
            dgvReport.Columns["Year"].HeaderText = "Yıl";
            dgvReport.Columns["Month"].HeaderText = "Ay";
            dgvReport.Columns["ActionType"].HeaderText = "İşlem Türü";
            dgvReport.Columns["Incoming"].HeaderText = "Gelen Ürün";
            dgvReport.Columns["Outgoing"].HeaderText = "Çıkan Ürün";

            int index = 0;
            dgvReport.Columns["ProductName"].DisplayIndex = index++;
            dgvReport.Columns["Brand"].DisplayIndex = index++;
            dgvReport.Columns["ColorCode"].DisplayIndex = index++;
            dgvReport.Columns["Year"].DisplayIndex = index++;
            dgvReport.Columns["Month"].DisplayIndex = index++;
            dgvReport.Columns["ActionType"].DisplayIndex = index++;
            dgvReport.Columns["Incoming"].DisplayIndex = index++;
            dgvReport.Columns["Outgoing"].DisplayIndex = index++;
        }

        // DataGridView’de Month sütununu isim olarak göstermek için
        private void DgvReport_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvReport.Columns[e.ColumnIndex].Name == "Month" && e.Value != null)
            {
                int monthNumber = Convert.ToInt32(e.Value);
                e.Value = new DateTime(1, monthNumber, 1).ToString("MMMM");
                e.FormattingApplied = true;
            }
        }

        private void bFiltre_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void bExcel_Click(object sender, EventArgs e)
        {
            ExcelExporter.ExportDataGridViewToExcel(dgvReport);
        }
    }
}
