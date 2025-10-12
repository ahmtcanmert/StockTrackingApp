namespace StockTrackingApp
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvReport = new DataGridView();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            bFiltre = new Button();
            cmbYear = new ComboBox();
            cmbMonth = new ComboBox();
            bExcel = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.8205128F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.17949F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 352F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 790F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(dgvReport, 2, 2);
            tableLayoutPanel1.Controls.Add(panel1, 2, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 37.1428566F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 62.8571434F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 219F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1198, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvReport
            // 
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dgvReport, 2);
            dgvReport.Dock = DockStyle.Fill;
            dgvReport.Location = new Point(20, 56);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 51;
            tableLayoutPanel1.SetRowSpan(dgvReport, 2);
            dgvReport.Size = new Size(1136, 288);
            dgvReport.TabIndex = 0;
            // 
            // panel1
            // 
            tableLayoutPanel1.SetColumnSpan(panel1, 2);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Location = new Point(20, 350);
            panel1.Name = "panel1";
            panel1.Size = new Size(997, 76);
            panel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 238F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 49F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 86F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 348F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 193F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(bFiltre, 4, 0);
            tableLayoutPanel2.Controls.Add(cmbYear, 1, 0);
            tableLayoutPanel2.Controls.Add(cmbMonth, 3, 0);
            tableLayoutPanel2.Controls.Add(bExcel, 5, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 51.31579F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel2.Size = new Size(997, 76);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // bFiltre
            // 
            bFiltre.Location = new Point(459, 3);
            bFiltre.Name = "bFiltre";
            bFiltre.Size = new Size(94, 29);
            bFiltre.TabIndex = 2;
            bFiltre.Text = "Filtrele";
            bFiltre.UseVisualStyleBackColor = true;
            bFiltre.Click += bFiltre_Click;
            // 
            // cmbYear
            // 
            cmbYear.FormattingEnabled = true;
            cmbYear.Location = new Point(86, 3);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(151, 28);
            cmbYear.TabIndex = 3;
            // 
            // cmbMonth
            // 
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(373, 3);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(80, 28);
            cmbMonth.TabIndex = 4;
            // 
            // bExcel
            // 
            bExcel.Location = new Point(807, 39);
            bExcel.Name = "bExcel";
            bExcel.Size = new Size(94, 26);
            bExcel.TabIndex = 5;
            bExcel.Text = "Excel";
            bExcel.UseVisualStyleBackColor = true;
            bExcel.Click += bExcel_Click;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "ReportForm";
            Text = "LogForm";
            Load += LogForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvReport;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button bFiltre;
        private ComboBox cmbYear;
        private ComboBox cmbMonth;
        private Button bExcel;
    }
}