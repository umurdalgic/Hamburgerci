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
    public partial class MenuEkle : Form
    {
        public MenuEkle()
        {
            InitializeComponent();
        }

        private void btnMenuKaydet_Click(object sender, EventArgs e)
        {
            Form1.menuler.Add(new Menuler() { Ad = txtMenuAd.Text, Fiyat = Convert.ToDecimal(txtMenuFiyat.Text) });
            MessageBox.Show($"{txtMenuAd.Text} başarıyla menülere eklendi.","Kayıt Edildi.",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
