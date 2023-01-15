using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class KullanılanÜrünlerSayfası : Form
    {
        public KullanılanÜrünlerSayfası()
        {
            InitializeComponent();
        }
        public string ArananUrunAdi = "a";
        public int AlinabilecekMiktar = 0;
        public int ToplamMiktar = 0;
        public int OduncVerilenMiktar = 0;
        public string[] UrunuAlanKisiler = new string[] { };

        private void button1_Click(object sender, EventArgs e)
        {
            ArananUrunAdi=textBox1.Text;
            listBox1.Items.AddRange(UrunuAlanKisiler);
            textBox2.Text = AlinabilecekMiktar.ToString();
            textBox3.Text = ToplamMiktar.ToString();
            textBox4.Text = OduncVerilenMiktar.ToString();
        }
    }
}
