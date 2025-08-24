namespace StockTrackingApp
{
    partial class AddItemForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbUrunAdi = new TextBox();
            tbMarka = new TextBox();
            tbRenkKodu = new TextBox();
            tbEbat = new TextBox();
            tbFiyat = new TextBox();
            bUrunEkle = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 169F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 43F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 277F));
            tableLayoutPanel1.Controls.Add(label1, 2, 2);
            tableLayoutPanel1.Controls.Add(label2, 2, 3);
            tableLayoutPanel1.Controls.Add(label3, 2, 4);
            tableLayoutPanel1.Controls.Add(label4, 2, 5);
            tableLayoutPanel1.Controls.Add(label5, 2, 6);
            tableLayoutPanel1.Controls.Add(tbUrunAdi, 4, 2);
            tableLayoutPanel1.Controls.Add(tbMarka, 4, 3);
            tableLayoutPanel1.Controls.Add(tbRenkKodu, 4, 4);
            tableLayoutPanel1.Controls.Add(tbEbat, 4, 5);
            tableLayoutPanel1.Controls.Add(tbFiyat, 4, 6);
            tableLayoutPanel1.Controls.Add(bUrunEkle, 4, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 140F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(177, 82);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 0;
            label1.Text = "Ürün";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 116);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Marka";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(177, 150);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 2;
            label3.Text = "Renk Kodu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(177, 184);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 3;
            label4.Text = "Ebat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(177, 221);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 4;
            label5.Text = "Fiyat";
            // 
            // tbUrunAdi
            // 
            tbUrunAdi.Location = new Point(313, 85);
            tbUrunAdi.Name = "tbUrunAdi";
            tbUrunAdi.Size = new Size(125, 27);
            tbUrunAdi.TabIndex = 6;
            // 
            // tbMarka
            // 
            tbMarka.Location = new Point(313, 119);
            tbMarka.Name = "tbMarka";
            tbMarka.Size = new Size(125, 27);
            tbMarka.TabIndex = 7;
            // 
            // tbRenkKodu
            // 
            tbRenkKodu.Location = new Point(313, 153);
            tbRenkKodu.Name = "tbRenkKodu";
            tbRenkKodu.Size = new Size(125, 27);
            tbRenkKodu.TabIndex = 8;
            // 
            // tbEbat
            // 
            tbEbat.Location = new Point(313, 187);
            tbEbat.Name = "tbEbat";
            tbEbat.Size = new Size(125, 27);
            tbEbat.TabIndex = 9;
            tbEbat.KeyPress += tbEbat_KeyPress;
            // 
            // tbFiyat
            // 
            tbFiyat.Location = new Point(313, 224);
            tbFiyat.Name = "tbFiyat";
            tbFiyat.Size = new Size(125, 27);
            tbFiyat.TabIndex = 10;
            tbFiyat.KeyPress += tbFiyat_KeyPress;
            // 
            // bUrunEkle
            // 
            bUrunEkle.Location = new Point(313, 267);
            bUrunEkle.Name = "bUrunEkle";
            bUrunEkle.Size = new Size(94, 29);
            bUrunEkle.TabIndex = 5;
            bUrunEkle.Text = "Ürün Ekle";
            bUrunEkle.UseVisualStyleBackColor = true;
            bUrunEkle.Click += bUrunEkle_Click;
            // 
            // AddItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "AddItemForm";
            Text = "UrunEkleme";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button bUrunEkle;
        private TextBox tbUrunAdi;
        private TextBox tbMarka;
        private TextBox tbRenkKodu;
        private TextBox tbEbat;
        private TextBox tbFiyat;
    }
}