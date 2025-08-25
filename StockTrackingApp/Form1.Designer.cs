namespace StockTrackingApp
{
    partial class Form1
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
            dgTablo = new DataGridView();
            tbMağazaStok = new TextBox();
            tbSevkiyat = new TextBox();
            tbGuncelle = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            bMağazaArttır = new Button();
            bMağazaAzalt = new Button();
            bSevkiyatAzalt = new Button();
            bSevkiyatArttır = new Button();
            bGüncelle = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            bUrunEkle = new Button();
            bUrunSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dgTablo).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgTablo
            // 
            dgTablo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dgTablo, 11);
            dgTablo.Dock = DockStyle.Fill;
            dgTablo.Location = new Point(83, 91);
            dgTablo.Name = "dgTablo";
            dgTablo.ReadOnly = true;
            dgTablo.RowHeadersWidth = 51;
            dgTablo.Size = new Size(1257, 247);
            dgTablo.TabIndex = 0;
            dgTablo.CellClick += dgTablo_CellClick;
            // 
            // tbMağazaStok
            // 
            tableLayoutPanel1.SetColumnSpan(tbMağazaStok, 2);
            tbMağazaStok.Dock = DockStyle.Fill;
            tbMağazaStok.Location = new Point(83, 381);
            tbMağazaStok.Name = "tbMağazaStok";
            tbMağazaStok.Size = new Size(147, 27);
            tbMağazaStok.TabIndex = 1;
            tbMağazaStok.KeyPress += tbMağazaStokArttır_KeyPress;
            // 
            // tbSevkiyat
            // 
            tableLayoutPanel1.SetColumnSpan(tbSevkiyat, 2);
            tbSevkiyat.Dock = DockStyle.Fill;
            tbSevkiyat.Location = new Point(470, 381);
            tbSevkiyat.Name = "tbSevkiyat";
            tbSevkiyat.Size = new Size(229, 27);
            tbSevkiyat.TabIndex = 3;
            tbSevkiyat.KeyPress += tbSevkiyat_KeyPress;
            // 
            // tbGuncelle
            // 
            tbGuncelle.Dock = DockStyle.Fill;
            tbGuncelle.Location = new Point(902, 381);
            tbGuncelle.Name = "tbGuncelle";
            tbGuncelle.Size = new Size(174, 27);
            tbGuncelle.TabIndex = 5;
            tbGuncelle.KeyPress += tbGuncelle_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(35, 378);
            label1.Name = "label1";
            label1.Size = new Size(42, 38);
            label1.TabIndex = 6;
            label1.Text = "Stok ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(353, 378);
            label3.Name = "label3";
            label3.Size = new Size(111, 38);
            label3.TabIndex = 8;
            label3.Text = "Sevkiyat ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(777, 378);
            label5.Name = "label5";
            label5.Size = new Size(119, 38);
            label5.TabIndex = 10;
            label5.Text = "Depodan Azalt";
            // 
            // bMağazaArttır
            // 
            bMağazaArttır.BackColor = Color.LightGreen;
            bMağazaArttır.Dock = DockStyle.Fill;
            bMağazaArttır.ForeColor = SystemColors.ButtonHighlight;
            bMağazaArttır.Location = new Point(83, 454);
            bMağazaArttır.Name = "bMağazaArttır";
            bMağazaArttır.Size = new Size(69, 30);
            bMağazaArttır.TabIndex = 11;
            bMağazaArttır.Text = "Arttır";
            bMağazaArttır.UseVisualStyleBackColor = false;
            bMağazaArttır.Click += bMağazaArttır_Click;
            // 
            // bMağazaAzalt
            // 
            bMağazaAzalt.BackColor = Color.OrangeRed;
            bMağazaAzalt.Dock = DockStyle.Fill;
            bMağazaAzalt.ForeColor = SystemColors.ButtonHighlight;
            bMağazaAzalt.Location = new Point(158, 454);
            bMağazaAzalt.Name = "bMağazaAzalt";
            bMağazaAzalt.Size = new Size(72, 30);
            bMağazaAzalt.TabIndex = 12;
            bMağazaAzalt.Text = "Azalt";
            bMağazaAzalt.UseVisualStyleBackColor = false;
            bMağazaAzalt.Click += bMağazaAzalt_Click;
            // 
            // bSevkiyatAzalt
            // 
            bSevkiyatAzalt.BackColor = Color.OrangeRed;
            bSevkiyatAzalt.Dock = DockStyle.Fill;
            bSevkiyatAzalt.ForeColor = SystemColors.ButtonHighlight;
            bSevkiyatAzalt.Location = new Point(587, 454);
            bSevkiyatAzalt.Name = "bSevkiyatAzalt";
            bSevkiyatAzalt.Size = new Size(112, 30);
            bSevkiyatAzalt.TabIndex = 14;
            bSevkiyatAzalt.Text = "Azalt";
            bSevkiyatAzalt.UseVisualStyleBackColor = false;
            bSevkiyatAzalt.Click += bSevkiyatAzalt_Click;
            // 
            // bSevkiyatArttır
            // 
            bSevkiyatArttır.BackColor = Color.LightGreen;
            bSevkiyatArttır.Dock = DockStyle.Fill;
            bSevkiyatArttır.ForeColor = SystemColors.ButtonHighlight;
            bSevkiyatArttır.Location = new Point(470, 454);
            bSevkiyatArttır.Name = "bSevkiyatArttır";
            bSevkiyatArttır.Size = new Size(111, 30);
            bSevkiyatArttır.TabIndex = 13;
            bSevkiyatArttır.Text = "Arttır";
            bSevkiyatArttır.UseVisualStyleBackColor = false;
            bSevkiyatArttır.Click += bSevkiyatArttır_Click;
            // 
            // bGüncelle
            // 
            bGüncelle.Dock = DockStyle.Fill;
            bGüncelle.Location = new Point(902, 454);
            bGüncelle.Name = "bGüncelle";
            bGüncelle.Size = new Size(174, 30);
            bGüncelle.TabIndex = 15;
            bGüncelle.Text = "Güncelle";
            bGüncelle.UseVisualStyleBackColor = true;
            bGüncelle.Click += bGüncelle_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 15;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.512504F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.341742F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.8238707F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.3218842F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 118F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 72F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 199F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(bGüncelle, 10, 6);
            tableLayoutPanel1.Controls.Add(label1, 1, 4);
            tableLayoutPanel1.Controls.Add(tbGuncelle, 10, 4);
            tableLayoutPanel1.Controls.Add(tbMağazaStok, 2, 4);
            tableLayoutPanel1.Controls.Add(label5, 9, 4);
            tableLayoutPanel1.Controls.Add(bMağazaArttır, 2, 6);
            tableLayoutPanel1.Controls.Add(bMağazaAzalt, 3, 6);
            tableLayoutPanel1.Controls.Add(tbSevkiyat, 6, 4);
            tableLayoutPanel1.Controls.Add(bSevkiyatAzalt, 7, 6);
            tableLayoutPanel1.Controls.Add(bSevkiyatArttır, 6, 6);
            tableLayoutPanel1.Controls.Add(label3, 5, 4);
            tableLayoutPanel1.Controls.Add(bUrunEkle, 12, 3);
            tableLayoutPanel1.Controls.Add(dgTablo, 2, 2);
            tableLayoutPanel1.Controls.Add(bUrunSil, 12, 5);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.669619F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90.33038F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.Size = new Size(1400, 506);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // bUrunEkle
            // 
            tableLayoutPanel1.SetColumnSpan(bUrunEkle, 2);
            bUrunEkle.Location = new Point(1281, 344);
            bUrunEkle.Name = "bUrunEkle";
            bUrunEkle.Size = new Size(93, 31);
            bUrunEkle.TabIndex = 16;
            bUrunEkle.Text = "Ürün Ekle";
            bUrunEkle.UseVisualStyleBackColor = true;
            bUrunEkle.Click += bUrunEkle_Click;
            // 
            // bUrunSil
            // 
            bUrunSil.BackColor = Color.Red;
            tableLayoutPanel1.SetColumnSpan(bUrunSil, 2);
            bUrunSil.ForeColor = Color.White;
            bUrunSil.Location = new Point(1281, 419);
            bUrunSil.Name = "bUrunSil";
            bUrunSil.Size = new Size(93, 29);
            bUrunSil.TabIndex = 17;
            bUrunSil.Text = "Ürün Sil";
            bUrunSil.UseVisualStyleBackColor = false;
            bUrunSil.Click += bUrunSil_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1400, 506);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgTablo).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgTablo;
        private TextBox tbMağazaStok;
        private TextBox tbSevkiyat;
        private TextBox tbGuncelle;
        private Label label1;
        private Label label3;
        private Label label5;
        private Button bMağazaArttır;
        private Button bMağazaAzalt;
        private Button bSevkiyatAzalt;
        private Button bSevkiyatArttır;
        private Button bGüncelle;
        private TableLayoutPanel tableLayoutPanel1;
        private Button bUrunEkle;
        private Button bUrunSil;
    }
}
