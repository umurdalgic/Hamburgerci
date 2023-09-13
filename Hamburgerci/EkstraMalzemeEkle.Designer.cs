namespace Hamburgerci
{
    partial class EkstraMalzemeEkle
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            txtMalzemeAd = new TextBox();
            txtMalzemeFiyat = new TextBox();
            btnMalzemeKaydet = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnMalzemeKaydet);
            groupBox1.Controls.Add(txtMalzemeFiyat);
            groupBox1.Controls.Add(txtMalzemeAd);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(305, 144);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "EKSTRA MALZEME BİLGİLERİ";
            // 
            // label1
            // 
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(120, 23);
            label1.TabIndex = 4;
            label1.Text = "Ekstra Malzeme Adı:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new Point(0, 64);
            label2.Name = "label2";
            label2.Size = new Size(126, 23);
            label2.TabIndex = 5;
            label2.Text = "Fiyatı:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtMalzemeAd
            // 
            txtMalzemeAd.Location = new Point(132, 35);
            txtMalzemeAd.Name = "txtMalzemeAd";
            txtMalzemeAd.Size = new Size(167, 23);
            txtMalzemeAd.TabIndex = 6;
            // 
            // txtMalzemeFiyat
            // 
            txtMalzemeFiyat.Location = new Point(132, 64);
            txtMalzemeFiyat.Name = "txtMalzemeFiyat";
            txtMalzemeFiyat.Size = new Size(167, 23);
            txtMalzemeFiyat.TabIndex = 7;
            // 
            // btnMalzemeKaydet
            // 
            btnMalzemeKaydet.Location = new Point(132, 93);
            btnMalzemeKaydet.Name = "btnMalzemeKaydet";
            btnMalzemeKaydet.Size = new Size(167, 43);
            btnMalzemeKaydet.TabIndex = 8;
            btnMalzemeKaydet.Text = "EKSTRA MALZEMEYİ KAYDET";
            btnMalzemeKaydet.UseVisualStyleBackColor = true;
            btnMalzemeKaydet.Click += btnMalzemeKaydet_Click;
            // 
            // EkstraMalzemeEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 165);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EkstraMalzemeEkle";
            Text = "EkstraMalzemeEkle";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnMalzemeKaydet;
        private TextBox txtMalzemeFiyat;
        private TextBox txtMalzemeAd;
        private Label label2;
    }
}