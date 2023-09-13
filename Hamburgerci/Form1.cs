namespace Hamburgerci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void ChildForm(Form childForm)
        {
            this.Width = childForm.Width + 30;
            this.Height = childForm.Height + 125;
            bool status = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form.Text == childForm.Text)
                {
                    status = true;
                    form.Activate();
                }
                else
                {
                    form.Close();
                }
            }
            if (status == false)
            {
                childForm.MdiParent = this;
                childForm.Dock = DockStyle.Fill;
                childForm.Show();
            }
        }
        public static List<Malzeme> malzemeler = new List<Malzeme>()
                    {
            new Malzeme() {Ad="Ketçap",Fiyat=0.5M},
            new Malzeme() {Ad="Mayonez",Fiyat=0.5M},
            new Malzeme() {Ad="Hardal",Fiyat=0.75M},
            new Malzeme() {Ad="BBQ",Fiyat=0.75M},
            new Malzeme() {Ad="Acý Sos",Fiyat=0.75M},
            new Malzeme() {Ad="Ranch",Fiyat=0.75M}
        };
        public static List<Menuler> menuler = new List<Menuler>()
        {
            new Menuler() {Ad="Hamburger Menü",Fiyat=110},
            new Menuler() {Ad="Cheeseburger Menü",Fiyat=130},
            new Menuler() {Ad="Chicken Burger Menü",Fiyat=130},
            new Menuler() {Ad="Fish Burger Menü",Fiyat=150},
            new Menuler() {Ad="Veggie Burger Menü",Fiyat=100},
            new Menuler() {Ad="Big Burger Menü",Fiyat=170}
        };

        private void sipariþOluþturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new SiparisOlustur());
        }

        private void siparisBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new SiparisBilgileri());
        }

        private void menuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new MenuEkle());
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new EkstraMalzemeEkle());
        }

    }
}