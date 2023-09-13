namespace Hamburgerci
{
    partial class SiparisOlustur
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            cmbMenuler = new ComboBox();
            grpBoyut = new GroupBox();
            rdbBuyuk = new RadioButton();
            rdbOrta = new RadioButton();
            rdbKucuk = new RadioButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            btnSiparisEkle = new Button();
            listBox1 = new ListBox();
            label4 = new Label();
            lblToplamFiyat = new Label();
            btnSiparisTamamla = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpBoyut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1200x627_hamburger_nerenin_yemegi_hamburger_hangi_ulkenin_yemegidir_1632722854093;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(301, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 203);
            label1.Name = "label1";
            label1.Size = new Size(133, 23);
            label1.TabIndex = 1;
            label1.Text = "MENÜ SEÇİN";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbMenuler
            // 
            cmbMenuler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMenuler.FormattingEnabled = true;
            cmbMenuler.Location = new Point(12, 229);
            cmbMenuler.Name = "cmbMenuler";
            cmbMenuler.Size = new Size(289, 23);
            cmbMenuler.TabIndex = 2;
            // 
            // grpBoyut
            // 
            grpBoyut.Controls.Add(rdbBuyuk);
            grpBoyut.Controls.Add(rdbOrta);
            grpBoyut.Controls.Add(rdbKucuk);
            grpBoyut.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grpBoyut.Location = new Point(12, 258);
            grpBoyut.Name = "grpBoyut";
            grpBoyut.Size = new Size(289, 91);
            grpBoyut.TabIndex = 3;
            grpBoyut.TabStop = false;
            grpBoyut.Text = "BOYUT SEÇİNİZ";
            // 
            // rdbBuyuk
            // 
            rdbBuyuk.AutoSize = true;
            rdbBuyuk.Location = new Point(144, 38);
            rdbBuyuk.Name = "rdbBuyuk";
            rdbBuyuk.Size = new Size(72, 25);
            rdbBuyuk.TabIndex = 4;
            rdbBuyuk.TabStop = true;
            rdbBuyuk.Text = "Büyük";
            rdbBuyuk.UseVisualStyleBackColor = true;
            // 
            // rdbOrta
            // 
            rdbOrta.AutoSize = true;
            rdbOrta.Location = new Point(78, 38);
            rdbOrta.Name = "rdbOrta";
            rdbOrta.Size = new Size(60, 25);
            rdbOrta.TabIndex = 4;
            rdbOrta.TabStop = true;
            rdbOrta.Text = "Orta";
            rdbOrta.UseVisualStyleBackColor = true;
            // 
            // rdbKucuk
            // 
            rdbKucuk.AutoSize = true;
            rdbKucuk.Location = new Point(0, 38);
            rdbKucuk.Name = "rdbKucuk";
            rdbKucuk.Size = new Size(72, 25);
            rdbKucuk.TabIndex = 0;
            rdbKucuk.TabStop = true;
            rdbKucuk.Text = "Küçük";
            rdbKucuk.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(12, 383);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(289, 128);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 352);
            label2.Name = "label2";
            label2.Size = new Size(133, 23);
            label2.TabIndex = 5;
            label2.Text = "MALZEME SEÇİN";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 533);
            label3.Name = "label3";
            label3.Size = new Size(133, 23);
            label3.TabIndex = 6;
            label3.Text = "ADET:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(68, 533);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(160, 23);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnSiparisEkle
            // 
            btnSiparisEkle.Location = new Point(12, 577);
            btnSiparisEkle.Name = "btnSiparisEkle";
            btnSiparisEkle.Size = new Size(216, 49);
            btnSiparisEkle.TabIndex = 8;
            btnSiparisEkle.Text = "SİPARİŞ EKLE";
            btnSiparisEkle.UseVisualStyleBackColor = true;
            btnSiparisEkle.Click += btnSiparisEkle_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(255, 224, 192);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(307, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(381, 559);
            listBox1.TabIndex = 9;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(247, 588);
            label4.Name = "label4";
            label4.Size = new Size(133, 23);
            label4.TabIndex = 10;
            label4.Text = "TOPLAM TUTAR:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblToplamFiyat
            // 
            lblToplamFiyat.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplamFiyat.ForeColor = Color.SaddleBrown;
            lblToplamFiyat.Location = new Point(374, 588);
            lblToplamFiyat.Name = "lblToplamFiyat";
            lblToplamFiyat.Size = new Size(133, 23);
            lblToplamFiyat.TabIndex = 11;
            lblToplamFiyat.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSiparisTamamla
            // 
            btnSiparisTamamla.Location = new Point(513, 577);
            btnSiparisTamamla.Name = "btnSiparisTamamla";
            btnSiparisTamamla.Size = new Size(167, 49);
            btnSiparisTamamla.TabIndex = 12;
            btnSiparisTamamla.Text = "SİPARİŞİ TAMAMLA";
            btnSiparisTamamla.UseVisualStyleBackColor = true;
            btnSiparisTamamla.Click += btnSiparisTamamla_Click;
            // 
            // SiparisOlustur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(692, 629);
            Controls.Add(btnSiparisTamamla);
            Controls.Add(lblToplamFiyat);
            Controls.Add(label4);
            Controls.Add(listBox1);
            Controls.Add(btnSiparisEkle);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(grpBoyut);
            Controls.Add(cmbMenuler);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SiparisOlustur";
            Text = "SiparisOlustur";
            Load += SiparisOlustur_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpBoyut.ResumeLayout(false);
            grpBoyut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox cmbMenuler;
        private GroupBox grpBoyut;
        private RadioButton rdbKucuk;
        private RadioButton rdbBuyuk;
        private RadioButton rdbOrta;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Button btnSiparisEkle;
        private ListBox listBox1;
        private Label label4;
        private Label lblToplamFiyat;
        private Button btnSiparisTamamla;
    }
}