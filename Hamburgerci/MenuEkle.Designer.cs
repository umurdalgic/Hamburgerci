namespace Hamburgerci
{
    partial class MenuEkle
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
            btnMenuKaydet = new Button();
            txtMenuFiyat = new TextBox();
            txtMenuAd = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnMenuKaydet);
            groupBox1.Controls.Add(txtMenuFiyat);
            groupBox1.Controls.Add(txtMenuAd);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(282, 144);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "MENÜ BİLGİLERİ";
            // 
            // btnMenuKaydet
            // 
            btnMenuKaydet.Location = new Point(100, 93);
            btnMenuKaydet.Name = "btnMenuKaydet";
            btnMenuKaydet.Size = new Size(167, 43);
            btnMenuKaydet.TabIndex = 8;
            btnMenuKaydet.Text = "MENÜYÜ KAYDET";
            btnMenuKaydet.UseVisualStyleBackColor = true;
            btnMenuKaydet.Click += btnMenuKaydet_Click;
            // 
            // txtMenuFiyat
            // 
            txtMenuFiyat.Location = new Point(100, 64);
            txtMenuFiyat.Name = "txtMenuFiyat";
            txtMenuFiyat.Size = new Size(167, 23);
            txtMenuFiyat.TabIndex = 7;
            // 
            // txtMenuAd
            // 
            txtMenuAd.Location = new Point(100, 35);
            txtMenuAd.Name = "txtMenuAd";
            txtMenuAd.Size = new Size(167, 23);
            txtMenuAd.TabIndex = 6;
            // 
            // label2
            // 
            label2.Location = new Point(-32, 64);
            label2.Name = "label2";
            label2.Size = new Size(126, 23);
            label2.TabIndex = 5;
            label2.Text = "Fiyatı:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(88, 23);
            label1.TabIndex = 4;
            label1.Text = "Menü Adı:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // MenuEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 164);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuEkle";
            Text = "MenuEkle";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnMenuKaydet;
        private TextBox txtMenuFiyat;
        private TextBox txtMenuAd;
        private Label label2;
        private Label label1;
    }
}