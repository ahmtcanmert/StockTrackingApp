using System;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace StockTrackingApp.Utils
{
    public static class ExcelExporter
    {
        public static void ExportDataGridViewToExcel(DataGridView dgv)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("Tabloda veri yok!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Dosyaları (*.xlsx)|*.xlsx";
                sfd.FileName = "Export.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Sheet1");

                            // Sadece görünür sütunları ekle
                            int colIndex = 1;
                            for (int i = 0; i < dgv.Columns.Count; i++)
                            {
                                if (dgv.Columns[i].Visible)
                                {
                                    worksheet.Cell(1, colIndex).Value = dgv.Columns[i].HeaderText;
                                    colIndex++;
                                }
                            }

                            // Satır verilerini ekle (sadece görünür sütunlar)
                            int currentRow = 2;
                            foreach (DataGridViewRow row in dgv.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    colIndex = 1;
                                    for (int i = 0; i < dgv.Columns.Count; i++)
                                    {
                                        if (dgv.Columns[i].Visible)
                                        {
                                            worksheet.Cell(currentRow, colIndex).Value = row.Cells[i].Value?.ToString() ?? "";
                                            colIndex++;
                                        }
                                    }
                                    currentRow++;
                                }
                            }

                            workbook.SaveAs(sfd.FileName);
                        }

                        MessageBox.Show("Excel dosyası başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
