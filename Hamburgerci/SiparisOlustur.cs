using Hamburgerci.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hamburgerci
{
    public partial class SiparisOlustur : Form
    {
        public SiparisOlustur()
        {
            InitializeComponent();
        }




        private void SiparisOlustur_Load(object sender, EventArgs e)
        {
            foreach (Menuler menu in Form1.menuler)
            {
                cmbMenuler.Items.Add(menu);
            }
            cmbMenuler.SelectedIndex = 0;
            rdbKucuk.Checked = true;
            foreach (Malzeme malzeme in Form1.malzemeler)
            {
                flowLayoutPanel1.Controls.Add(new CheckBox() { Text = malzeme.Ad, Tag = malzeme });
            }
        }

        
        public static List<Siparis> siparisler = new List<Siparis>();

        public decimal toplamTutar;
        public decimal malzemeTutar;
        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
          
        sayac++;
            List<Malzeme> malzemes = new List<Malzeme>();

            Siparis yeniSiparis = new Siparis();
            yeniSiparis.Menu = (Menuler)cmbMenuler.SelectedItem;

            foreach (CheckBox checkBox in flowLayoutPanel1.Controls)
            {
                if (checkBox.Checked)
                {
                    malzemes.Add(checkBox.Tag as Malzeme);
                }
            }

            yeniSiparis.Malzemeler = malzemes;

            if (rdbBuyuk.Checked)
            {
                yeniSiparis.MenuBoyutu = Boyut.Buyuk;
            }
            else if (rdbKucuk.Checked)
            {
                yeniSiparis.MenuBoyutu = Boyut.Kucuk;
            }
            else if (rdbOrta.Checked)
            {
                yeniSiparis.MenuBoyutu = Boyut.Orta;
            }
            yeniSiparis.Adet = numericUpDown1.Value;
            toplamTutar += yeniSiparis.ToplamFiyat();
            siparisler.Add(yeniSiparis);
            listBox1.Items.Add(yeniSiparis);
            lblToplamFiyat.Text = toplamTutar.ToString("C");
            Siparis.ToplamTutar += toplamTutar;
            malzemeTutar += yeniSiparis.MalzemeFiyati();
            Temizle();
            
        }

        public void Temizle()
        {
            foreach (Control item in this.Controls)
            {
                switch (item)
                {
                    case ComboBox:
                        cmbMenuler.SelectedIndex = 0;
                        break;
                    case GroupBox:
                        foreach (RadioButton rdb in grpBoyut.Controls)
                        {
                            rdb.Checked = false;
                        }
                        rdbKucuk.Checked = true;
                        break;
                    case FlowLayoutPanel:
                        foreach (CheckBox checkBox in flowLayoutPanel1.Controls)
                        {
                            checkBox.Checked = false;
                        }
                        break;
                    case NumericUpDown:
                        numericUpDown1.Value = 1;
                        break;
                }
            }
        }
        public static List<decimal> toplamSiparis = new List<decimal>();
        public static List<int> SatilanUrun = new List<int>();
        public static List<decimal> MalzemeTutari = new List<decimal>();
        public int sayac = 0;

        private void btnSiparisTamamla_Click(object sender, EventArgs e)
        {
            toplamTutar = 0;
            DialogResult result = MessageBox.Show($"Toplam Sipariş Tutarı: {lblToplamFiyat.Text}\nSatın almayı tamamlamak ister misiniz?", "Sipariş Bilgisi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                MalzemeTutari.Add(malzemeTutar);
                listBox1.Items.Clear();
                foreach (Siparis siparis in siparisler)
                {
                    toplamSiparis.Add(siparis.EnToplamTutar());
                }
                lblToplamFiyat.Text = "0 TL";
                for (int i = 0; i < sayac; i++)
                    SatilanUrun.Add(0);
                sayac = 0;
            }
            else if (result == DialogResult.Cancel)
            {

                MessageBox.Show("İptal Edildi.", "", MessageBoxButtons.OK);
                Temizle();
                listBox1.Items.Clear();

                lblToplamFiyat.Text = "0 TL";
                sayac = 0;
            }
        }

    }

}
