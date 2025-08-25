namespace StockTrackingApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bUrunSil = new Button();
            dgTablo = new DataGridView();
            bUrunEkle = new Button();
            label3 = new Label();
            bSevkiyatArttır = new Button();
            bSevkiyatAzalt = new Button();
            tbSevkiyat = new TextBox();
            bMağazaAzalt = new Button();
            bMağazaArttır = new Button();
            label5 = new Label();
            tbMağazaStok = new TextBox();
            tbGuncelle = new TextBox();
            label1 = new Label();
            bGüncelle = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgTablo).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // bUrunSil
            // 
            bUrunSil.BackColor = Color.Red;
            tableLayoutPanel3.SetColumnSpan(bUrunSil, 2);
            bUrunSil.Dock = DockStyle.Fill;
            bUrunSil.ForeColor = Color.White;
            bUrunSil.Location = new Point(1196, 47);
            bUrunSil.Name = "bUrunSil";
            bUrunSil.Size = new Size(88, 36);
            bUrunSil.TabIndex = 17;
            bUrunSil.Text = "Ürün Sil";
            bUrunSil.UseVisualStyleBackColor = false;
            bUrunSil.Click += bUrunSil_Click;
            // 
            // dgTablo
            // 
            dgTablo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel2.SetColumnSpan(dgTablo, 2);
            dgTablo.Dock = DockStyle.Fill;
            dgTablo.Location = new Point(3, 3);
            dgTablo.Name = "dgTablo";
            dgTablo.ReadOnly = true;
            dgTablo.RowHeadersWidth = 51;
            dgTablo.Size = new Size(1292, 262);
            dgTablo.TabIndex = 0;
            dgTablo.CellClick += dgTablo_CellClick;
            // 
            // bUrunEkle
            // 
            tableLayoutPanel3.SetColumnSpan(bUrunEkle, 2);
            bUrunEkle.Dock = DockStyle.Fill;
            bUrunEkle.Location = new Point(1196, 3);
            bUrunEkle.Name = "bUrunEkle";
            bUrunEkle.Size = new Size(88, 38);
            bUrunEkle.TabIndex = 16;
            bUrunEkle.Text = "Ürün Ekle";
            bUrunEkle.UseVisualStyleBackColor = true;
            bUrunEkle.Click += bUrunEkle_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(442, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 44);
            label3.TabIndex = 8;
            label3.Text = "Sevkiyat ";
            // 
            // bSevkiyatArttır
            // 
            bSevkiyatArttır.BackColor = Color.LightGreen;
            bSevkiyatArttır.Dock = DockStyle.Fill;
            bSevkiyatArttır.ForeColor = SystemColors.ButtonHighlight;
            bSevkiyatArttır.Location = new Point(536, 47);
            bSevkiyatArttır.Name = "bSevkiyatArttır";
            bSevkiyatArttır.Size = new Size(77, 36);
            bSevkiyatArttır.TabIndex = 13;
            bSevkiyatArttır.Text = "Arttır";
            bSevkiyatArttır.UseVisualStyleBackColor = false;
            bSevkiyatArttır.Click += bSevkiyatArttır_Click;
            // 
            // bSevkiyatAzalt
            // 
            bSevkiyatAzalt.BackColor = Color.OrangeRed;
            bSevkiyatAzalt.Dock = DockStyle.Fill;
            bSevkiyatAzalt.ForeColor = SystemColors.ButtonHighlight;
            bSevkiyatAzalt.Location = new Point(619, 47);
            bSevkiyatAzalt.Name = "bSevkiyatAzalt";
            bSevkiyatAzalt.Size = new Size(77, 36);
            bSevkiyatAzalt.TabIndex = 14;
            bSevkiyatAzalt.Text = "Azalt";
            bSevkiyatAzalt.UseVisualStyleBackColor = false;
            bSevkiyatAzalt.Click += bSevkiyatAzalt_Click;
            // 
            // tbSevkiyat
            // 
            tableLayoutPanel3.SetColumnSpan(tbSevkiyat, 2);
            tbSevkiyat.Dock = DockStyle.Fill;
            tbSevkiyat.Location = new Point(536, 3);
            tbSevkiyat.Name = "tbSevkiyat";
            tbSevkiyat.Size = new Size(160, 27);
            tbSevkiyat.TabIndex = 3;
            tbSevkiyat.KeyPress += tbSevkiyat_KeyPress;
            // 
            // bMağazaAzalt
            // 
            bMağazaAzalt.BackColor = Color.OrangeRed;
            bMağazaAzalt.Dock = DockStyle.Fill;
            bMağazaAzalt.ForeColor = SystemColors.ButtonHighlight;
            bMağazaAzalt.Location = new Point(207, 47);
            bMağazaAzalt.Name = "bMağazaAzalt";
            bMağazaAzalt.Size = new Size(77, 36);
            bMağazaAzalt.TabIndex = 12;
            bMağazaAzalt.Text = "Azalt";
            bMağazaAzalt.UseVisualStyleBackColor = false;
            bMağazaAzalt.Click += bMağazaAzalt_Click;
            // 
            // bMağazaArttır
            // 
            bMağazaArttır.BackColor = Color.LightGreen;
            bMağazaArttır.Dock = DockStyle.Fill;
            bMağazaArttır.ForeColor = SystemColors.ButtonHighlight;
            bMağazaArttır.Location = new Point(124, 47);
            bMağazaArttır.Name = "bMağazaArttır";
            bMağazaArttır.Size = new Size(77, 36);
            bMağazaArttır.TabIndex = 11;
            bMağazaArttır.Text = "Arttır";
            bMağazaArttır.UseVisualStyleBackColor = false;
            bMağazaArttır.Click += bMağazaArttır_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(831, 0);
            label5.Name = "label5";
            label5.Size = new Size(117, 44);
            label5.TabIndex = 10;
            label5.Text = "Depodan Azalt";
            // 
            // tbMağazaStok
            // 
            tableLayoutPanel3.SetColumnSpan(tbMağazaStok, 2);
            tbMağazaStok.Dock = DockStyle.Fill;
            tbMağazaStok.Location = new Point(124, 3);
            tbMağazaStok.Name = "tbMağazaStok";
            tbMağazaStok.Size = new Size(160, 27);
            tbMağazaStok.TabIndex = 1;
            tbMağazaStok.KeyPress += tbMağazaStokArttır_KeyPress;
            // 
            // tbGuncelle
            // 
            tbGuncelle.Dock = DockStyle.Fill;
            tbGuncelle.Location = new Point(954, 3);
            tbGuncelle.Name = "tbGuncelle";
            tbGuncelle.Size = new Size(169, 27);
            tbGuncelle.TabIndex = 5;
            tbGuncelle.KeyPress += tbGuncelle_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(43, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 44);
            label1.TabIndex = 6;
            label1.Text = "Stok ";
            // 
            // bGüncelle
            // 
            bGüncelle.Dock = DockStyle.Fill;
            bGüncelle.Location = new Point(954, 47);
            bGüncelle.Name = "bGüncelle";
            bGüncelle.Size = new Size(169, 36);
            bGüncelle.TabIndex = 15;
            bGüncelle.Text = "Güncelle";
            bGüncelle.UseVisualStyleBackColor = true;
            bGüncelle.Click += bGüncelle_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.6551743F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.3448257F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1012F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 252F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 11F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 2, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 2, 1);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 44.8275871F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 55.1724129F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 226F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 123F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1400, 506);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 16;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel3, 3);
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.66667F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 83F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 83F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 41F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 111F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 94F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 83F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 83F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 129F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 123F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 175F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 9F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 58F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 59F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 34F));
            tableLayoutPanel3.Controls.Add(label1, 1, 0);
            tableLayoutPanel3.Controls.Add(tbMağazaStok, 2, 0);
            tableLayoutPanel3.Controls.Add(bMağazaArttır, 2, 1);
            tableLayoutPanel3.Controls.Add(bMağazaAzalt, 3, 1);
            tableLayoutPanel3.Controls.Add(tbSevkiyat, 7, 0);
            tableLayoutPanel3.Controls.Add(label3, 6, 0);
            tableLayoutPanel3.Controls.Add(bSevkiyatAzalt, 8, 1);
            tableLayoutPanel3.Controls.Add(bSevkiyatArttır, 7, 1);
            tableLayoutPanel3.Controls.Add(bGüncelle, 11, 1);
            tableLayoutPanel3.Controls.Add(tbGuncelle, 11, 0);
            tableLayoutPanel3.Controls.Add(label5, 10, 0);
            tableLayoutPanel3.Controls.Add(bUrunEkle, 14, 0);
            tableLayoutPanel3.Controls.Add(bUrunSil, 14, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(58, 365);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50.6172829F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 49.3827171F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.Size = new Size(1287, 117);
            tableLayoutPanel3.TabIndex = 20;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 4);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(dgTablo, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(58, 42);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel1.SetRowSpan(tableLayoutPanel2, 2);
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 49.2957764F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1298, 268);
            tableLayoutPanel2.TabIndex = 19;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1400, 506);
            Controls.Add(tableLayoutPanel1);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgTablo).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button bUrunSil;
        private DataGridView dgTablo;
        private Button bUrunEkle;
        private Label label3;
        private Button bSevkiyatArttır;
        private Button bSevkiyatAzalt;
        private TextBox tbSevkiyat;
        private Button bMağazaAzalt;
        private Button bMağazaArttır;
        private Label label5;
        private TextBox tbMağazaStok;
        private TextBox tbGuncelle;
        private Label label1;
        private Button bGüncelle;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
    }
}
