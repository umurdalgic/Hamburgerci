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
    public partial class SiparisBilgileri : Form
    {
        public SiparisBilgileri()
        {
            InitializeComponent();
        }
        decimal ciro;
        decimal malzemeTutari;
        private void SiparisBilgileri_Load(object sender, EventArgs e)
        {
            label2.Text = Math.Round(Siparis.ToplamTutar*0.2M,2).ToString("C");
            label3.Text = SiparisOlustur.siparisler.Count().ToString();
            label4.Text = SiparisOlustur.SatilanUrun.Count().ToString();
            foreach (decimal item in SiparisOlustur.MalzemeTutari)
            {
                malzemeTutari += item;
            }
            label5.Text=malzemeTutari.ToString("C");
            listBox1.DataSource = SiparisOlustur.siparisler;
        }
    }
}
