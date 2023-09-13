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
    public partial class EkstraMalzemeEkle : Form
    {
        public EkstraMalzemeEkle()
        {
            InitializeComponent();
        }

        private void btnMalzemeKaydet_Click(object sender, EventArgs e)
        {
            Form1.malzemeler.Add(new Malzeme() { Ad = txtMalzemeAd.Text, Fiyat = Convert.ToDecimal(txtMalzemeFiyat.Text) });
            MessageBox.Show($"{txtMalzemeAd.Text} başarıyla malzemelere eklendi.", "Kayıt Edildi.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
