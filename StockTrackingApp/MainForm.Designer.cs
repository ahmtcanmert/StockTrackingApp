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
            tlpMain = new TableLayoutPanel();
            tlpSevk = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            pFiltrele = new Panel();
            tlpMenu = new TableLayoutPanel();
            bRapor = new Button();
            bGuncelle = new Button();
            bExcel = new Button();
            pFiltreleme = new Panel();
            tlpFiltre = new TableLayoutPanel();
            label2 = new Label();
            tbUrunAdi = new TextBox();
            label4 = new Label();
            tbMarka = new TextBox();
            label6 = new Label();
            tbRenkKodu = new TextBox();
            label7 = new Label();
            tbEbat = new TextBox();
            bTemizle = new Button();
            ((System.ComponentModel.ISupportInitialize)dgTablo).BeginInit();
            tlpMain.SuspendLayout();
            tlpSevk.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            pFiltrele.SuspendLayout();
            tlpMenu.SuspendLayout();
            pFiltreleme.SuspendLayout();
            tlpFiltre.SuspendLayout();
            SuspendLayout();
            // 
            // bUrunSil
            // 
            bUrunSil.BackColor = Color.Red;
            bUrunSil.ForeColor = Color.White;
            bUrunSil.Location = new Point(10, 261);
            bUrunSil.Name = "bUrunSil";
            bUrunSil.Size = new Size(76, 36);
            bUrunSil.TabIndex = 17;
            bUrunSil.Text = "Sil";
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
            dgTablo.Size = new Size(1268, 354);
            dgTablo.TabIndex = 0;
            dgTablo.CellClick += dgTablo_CellClick;
            // 
            // bUrunEkle
            // 
            bUrunEkle.Location = new Point(10, 197);
            bUrunEkle.Name = "bUrunEkle";
            bUrunEkle.Size = new Size(76, 38);
            bUrunEkle.TabIndex = 16;
            bUrunEkle.Text = "Ekle";
            bUrunEkle.UseVisualStyleBackColor = true;
            bUrunEkle.Click += bUrunEkle_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(459, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 44);
            label3.TabIndex = 8;
            label3.Text = "Sevkiyat ";
            // 
            // bSevkiyatArttır
            // 
            bSevkiyatArttır.BackColor = Color.Green;
            bSevkiyatArttır.Dock = DockStyle.Fill;
            bSevkiyatArttır.ForeColor = SystemColors.ButtonHighlight;
            bSevkiyatArttır.Location = new Point(553, 47);
            bSevkiyatArttır.Name = "bSevkiyatArttır";
            bSevkiyatArttır.Size = new Size(77, 36);
            bSevkiyatArttır.TabIndex = 13;
            bSevkiyatArttır.Text = "GÖNDER";
            bSevkiyatArttır.UseVisualStyleBackColor = false;
            bSevkiyatArttır.Click += bSevkiyatArttır_Click;
            // 
            // bSevkiyatAzalt
            // 
            bSevkiyatAzalt.BackColor = Color.OrangeRed;
            bSevkiyatAzalt.Dock = DockStyle.Fill;
            bSevkiyatAzalt.ForeColor = SystemColors.ButtonHighlight;
            bSevkiyatAzalt.Location = new Point(636, 47);
            bSevkiyatAzalt.Name = "bSevkiyatAzalt";
            bSevkiyatAzalt.Size = new Size(77, 36);
            bSevkiyatAzalt.TabIndex = 14;
            bSevkiyatAzalt.Text = "İPTAL";
            bSevkiyatAzalt.UseVisualStyleBackColor = false;
            bSevkiyatAzalt.Click += bSevkiyatAzalt_Click;
            // 
            // tbSevkiyat
            // 
            tlpSevk.SetColumnSpan(tbSevkiyat, 2);
            tbSevkiyat.Dock = DockStyle.Fill;
            tbSevkiyat.Location = new Point(553, 3);
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
            bMağazaAzalt.Location = new Point(266, 47);
            bMağazaAzalt.Name = "bMağazaAzalt";
            bMağazaAzalt.Size = new Size(77, 36);
            bMağazaAzalt.TabIndex = 12;
            bMağazaAzalt.Text = "ÇIKART";
            bMağazaAzalt.UseVisualStyleBackColor = false;
            bMağazaAzalt.Click += bMağazaAzalt_Click;
            // 
            // bMağazaArttır
            // 
            bMağazaArttır.BackColor = Color.Green;
            bMağazaArttır.Dock = DockStyle.Fill;
            bMağazaArttır.ForeColor = SystemColors.ButtonHighlight;
            bMağazaArttır.Location = new Point(183, 47);
            bMağazaArttır.Name = "bMağazaArttır";
            bMağazaArttır.Size = new Size(77, 36);
            bMağazaArttır.TabIndex = 11;
            bMağazaArttır.Text = "EKLE";
            bMağazaArttır.UseVisualStyleBackColor = false;
            bMağazaArttır.Click += bMağazaArttır_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(819, 0);
            label5.Name = "label5";
            label5.Size = new Size(117, 44);
            label5.TabIndex = 10;
            label5.Text = "Sevkiyat Tamam";
            // 
            // tbMağazaStok
            // 
            tlpSevk.SetColumnSpan(tbMağazaStok, 2);
            tbMağazaStok.Dock = DockStyle.Fill;
            tbMağazaStok.Location = new Point(183, 3);
            tbMağazaStok.Name = "tbMağazaStok";
            tbMağazaStok.Size = new Size(160, 27);
            tbMağazaStok.TabIndex = 1;
            tbMağazaStok.KeyPress += tbMağazaStokArttır_KeyPress;
            // 
            // tbGuncelle
            // 
            tbGuncelle.Dock = DockStyle.Fill;
            tbGuncelle.Location = new Point(942, 3);
            tbGuncelle.Name = "tbGuncelle";
            tbGuncelle.Size = new Size(169, 27);
            tbGuncelle.TabIndex = 5;
            tbGuncelle.KeyPress += tbGuncelle_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(103, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 44);
            label1.TabIndex = 6;
            label1.Text = "Depo";
            // 
            // bGüncelle
            // 
            bGüncelle.Dock = DockStyle.Fill;
            bGüncelle.Location = new Point(942, 47);
            bGüncelle.Name = "bGüncelle";
            bGüncelle.Size = new Size(169, 36);
            bGüncelle.TabIndex = 15;
            bGüncelle.Text = "SEVKİYAT TAMAM";
            bGüncelle.UseVisualStyleBackColor = true;
            bGüncelle.Click += bGüncelle_Click;
            // 
            // tlpMain
            // 
            tlpMain.BackColor = SystemColors.InactiveBorder;
            tlpMain.ColumnCount = 8;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 978F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 252F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 29F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 21F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpMain.Controls.Add(tlpSevk, 2, 4);
            tlpMain.Controls.Add(tableLayoutPanel2, 2, 1);
            tlpMain.Controls.Add(pFiltrele, 0, 0);
            tlpMain.Controls.Add(pFiltreleme, 2, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 6;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 40.3225822F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 59.6774178F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 255F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 123F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMain.Size = new Size(1418, 605);
            tlpMain.TabIndex = 18;
            // 
            // tlpSevk
            // 
            tlpSevk.ColumnCount = 16;
            tlpMain.SetColumnSpan(tlpSevk, 4);
            tlpSevk.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpSevk.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tlpSevk.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 83F));
            tlpSevk.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 83F));
            tlpSevk.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpSevk.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tlpSevk.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 94F));
            tlpSevk.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 83F));
            tlpSevk.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 83F));
            tlpSevk.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tlpSevk.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 123F));
            tlpSevk.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 175F));
            tlpSevk.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 9F));
            tlpSevk.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 58F));
            tlpSevk.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 59F));
            tlpSevk.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 34F));
            tlpSevk.Controls.Add(label1, 1, 0);
            tlpSevk.Controls.Add(tbMağazaStok, 2, 0);
            tlpSevk.Controls.Add(bMağazaArttır, 2, 1);
            tlpSevk.Controls.Add(bMağazaAzalt, 3, 1);
            tlpSevk.Controls.Add(tbSevkiyat, 7, 0);
            tlpSevk.Controls.Add(label3, 6, 0);
            tlpSevk.Controls.Add(bSevkiyatAzalt, 8, 1);
            tlpSevk.Controls.Add(bSevkiyatArttır, 7, 1);
            tlpSevk.Controls.Add(bGüncelle, 11, 1);
            tlpSevk.Controls.Add(tbGuncelle, 11, 0);
            tlpSevk.Controls.Add(label5, 10, 0);
            tlpSevk.Dock = DockStyle.Fill;
            tlpSevk.Location = new Point(111, 464);
            tlpSevk.Name = "tlpSevk";
            tlpSevk.RowCount = 3;
            tlpSevk.RowStyles.Add(new RowStyle(SizeType.Percent, 50.6172829F));
            tlpSevk.RowStyles.Add(new RowStyle(SizeType.Percent, 49.3827171F));
            tlpSevk.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpSevk.Size = new Size(1274, 117);
            tlpSevk.TabIndex = 20;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tlpMain.SetColumnSpan(tableLayoutPanel2, 4);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(dgTablo, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(111, 78);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tlpMain.SetRowSpan(tableLayoutPanel2, 2);
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 49.2957764F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 361F));
            tableLayoutPanel2.Size = new Size(1274, 360);
            tableLayoutPanel2.TabIndex = 19;
            // 
            // pFiltrele
            // 
            tlpMain.SetColumnSpan(pFiltrele, 2);
            pFiltrele.Controls.Add(tlpMenu);
            pFiltrele.Dock = DockStyle.Fill;
            pFiltrele.Location = new Point(3, 3);
            pFiltrele.Name = "pFiltrele";
            tlpMain.SetRowSpan(pFiltrele, 6);
            pFiltrele.Size = new Size(102, 599);
            pFiltrele.TabIndex = 21;
            // 
            // tlpMenu
            // 
            tlpMenu.BackColor = Color.PaleTurquoise;
            tlpMenu.ColumnCount = 3;
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.791209F));
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 91.20879F));
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 12F));
            tlpMenu.Controls.Add(bRapor, 1, 4);
            tlpMenu.Controls.Add(bGuncelle, 1, 11);
            tlpMenu.Controls.Add(bUrunSil, 1, 8);
            tlpMenu.Controls.Add(bUrunEkle, 1, 7);
            tlpMenu.Controls.Add(bExcel, 1, 9);
            tlpMenu.Dock = DockStyle.Fill;
            tlpMenu.Location = new Point(0, 0);
            tlpMenu.Name = "tlpMenu";
            tlpMenu.RowCount = 15;
            tlpMenu.RowStyles.Add(new RowStyle());
            tlpMenu.RowStyles.Add(new RowStyle());
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tlpMenu.Size = new Size(102, 599);
            tlpMenu.TabIndex = 0;
            // 
            // bRapor
            // 
            bRapor.Location = new Point(10, 86);
            bRapor.Name = "bRapor";
            bRapor.Size = new Size(76, 29);
            bRapor.TabIndex = 0;
            bRapor.Text = "Raporlar";
            bRapor.UseVisualStyleBackColor = true;
            bRapor.Click += bRapor_Click;
            // 
            // bGuncelle
            // 
            bGuncelle.Location = new Point(10, 386);
            bGuncelle.Name = "bGuncelle";
            bGuncelle.Size = new Size(76, 29);
            bGuncelle.TabIndex = 18;
            bGuncelle.Text = "Güncelle";
            bGuncelle.UseVisualStyleBackColor = true;
            bGuncelle.Click += bGuncelle_Click;
            // 
            // bExcel
            // 
            bExcel.Dock = DockStyle.Fill;
            bExcel.Location = new Point(10, 322);
            bExcel.Name = "bExcel";
            bExcel.Size = new Size(76, 38);
            bExcel.TabIndex = 19;
            bExcel.Text = "Excel";
            bExcel.UseVisualStyleBackColor = true;
            bExcel.Click += bExcel_Click;
            // 
            // pFiltreleme
            // 
            pFiltreleme.BackColor = Color.Cyan;
            tlpMain.SetColumnSpan(pFiltreleme, 4);
            pFiltreleme.Controls.Add(tlpFiltre);
            pFiltreleme.Dock = DockStyle.Fill;
            pFiltreleme.Location = new Point(111, 3);
            pFiltreleme.Name = "pFiltreleme";
            pFiltreleme.Size = new Size(1274, 69);
            pFiltreleme.TabIndex = 22;
            // 
            // tlpFiltre
            // 
            tlpFiltre.BackColor = Color.LightCyan;
            tlpFiltre.ColumnCount = 10;
            tlpFiltre.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.40777F));
            tlpFiltre.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.59223F));
            tlpFiltre.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 119F));
            tlpFiltre.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 161F));
            tlpFiltre.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 97F));
            tlpFiltre.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 157F));
            tlpFiltre.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 95F));
            tlpFiltre.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 203F));
            tlpFiltre.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tlpFiltre.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 84F));
            tlpFiltre.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpFiltre.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpFiltre.Controls.Add(label2, 0, 1);
            tlpFiltre.Controls.Add(tbUrunAdi, 1, 1);
            tlpFiltre.Controls.Add(label4, 2, 1);
            tlpFiltre.Controls.Add(tbMarka, 3, 1);
            tlpFiltre.Controls.Add(label6, 4, 1);
            tlpFiltre.Controls.Add(tbRenkKodu, 5, 1);
            tlpFiltre.Controls.Add(label7, 6, 1);
            tlpFiltre.Controls.Add(tbEbat, 7, 1);
            tlpFiltre.Controls.Add(bTemizle, 8, 1);
            tlpFiltre.Dock = DockStyle.Fill;
            tlpFiltre.Location = new Point(0, 0);
            tlpFiltre.Name = "tlpFiltre";
            tlpFiltre.RowCount = 3;
            tlpFiltre.RowStyles.Add(new RowStyle(SizeType.Percent, 37.5F));
            tlpFiltre.RowStyles.Add(new RowStyle(SizeType.Percent, 62.5F));
            tlpFiltre.RowStyles.Add(new RowStyle(SizeType.Absolute, 13F));
            tlpFiltre.Size = new Size(1274, 69);
            tlpFiltre.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 21);
            label2.Name = "label2";
            label2.Size = new Size(91, 35);
            label2.TabIndex = 4;
            label2.Text = "Ürün adı";
            // 
            // tbUrunAdi
            // 
            tbUrunAdi.Dock = DockStyle.Fill;
            tbUrunAdi.Location = new Point(100, 24);
            tbUrunAdi.Name = "tbUrunAdi";
            tbUrunAdi.Size = new Size(164, 27);
            tbUrunAdi.TabIndex = 0;
            tbUrunAdi.TextChanged += tbUrunAdi_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(270, 21);
            label4.Name = "label4";
            label4.Size = new Size(113, 35);
            label4.TabIndex = 5;
            label4.Text = "Marka";
            // 
            // tbMarka
            // 
            tbMarka.Location = new Point(389, 24);
            tbMarka.Name = "tbMarka";
            tbMarka.Size = new Size(125, 27);
            tbMarka.TabIndex = 1;
            tbMarka.TextChanged += tbMarka_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(550, 21);
            label6.Name = "label6";
            label6.Size = new Size(91, 35);
            label6.TabIndex = 6;
            label6.Text = "Renk Kodu";
            // 
            // tbRenkKodu
            // 
            tbRenkKodu.Location = new Point(647, 24);
            tbRenkKodu.Name = "tbRenkKodu";
            tbRenkKodu.Size = new Size(125, 27);
            tbRenkKodu.TabIndex = 2;
            tbRenkKodu.TextChanged += tbRenkKodu_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(804, 21);
            label7.Name = "label7";
            label7.Size = new Size(89, 35);
            label7.TabIndex = 7;
            label7.Text = "Ebat";
            // 
            // tbEbat
            // 
            tbEbat.Location = new Point(899, 24);
            tbEbat.Name = "tbEbat";
            tbEbat.Size = new Size(125, 27);
            tbEbat.TabIndex = 3;
            tbEbat.TextChanged += tbEbat_TextChanged;
            // 
            // bTemizle
            // 
            bTemizle.Location = new Point(1102, 24);
            bTemizle.Name = "bTemizle";
            bTemizle.Size = new Size(84, 29);
            bTemizle.TabIndex = 8;
            bTemizle.Text = "Temizle";
            bTemizle.UseVisualStyleBackColor = true;
            bTemizle.Click += bTemizle_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(1418, 605);
            Controls.Add(tlpMain);
            Name = "MainForm";
            Text = "Stok Tablosu";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgTablo).EndInit();
            tlpMain.ResumeLayout(false);
            tlpSevk.ResumeLayout(false);
            tlpSevk.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            pFiltrele.ResumeLayout(false);
            tlpMenu.ResumeLayout(false);
            pFiltreleme.ResumeLayout(false);
            tlpFiltre.ResumeLayout(false);
            tlpFiltre.PerformLayout();
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
        private TableLayoutPanel tlpMain;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tlpSevk;
        private Panel pFiltrele;
        private TableLayoutPanel tlpMenu;
        private Button bRapor;
        private Button bGuncelle;
        private Panel pFiltreleme;
        private TableLayoutPanel tlpFiltre;
        private TextBox tbUrunAdi;
        private TextBox tbMarka;
        private TextBox tbRenkKodu;
        private TextBox tbEbat;
        private Label label2;
        private Label label4;
        private Label label6;
        private Label label7;
        private Button bTemizle;
        private Button bExcel;
    }
}
