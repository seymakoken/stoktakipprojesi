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
    public partial class StokArama : Form
    {
        public StokArama()
        {
            InitializeComponent();
        }

        private void StokArama_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ÜrünEkle fr2 = new ÜrünEkle();
            fr2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ÜrünAl fr3 = new ÜrünAl();
            fr3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ürünİade fr4 = new Ürünİade();
            fr4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KullanılanÜrünlerSayfası fr5 = new KullanılanÜrünlerSayfası();
            fr5.ShowDialog();
        }
    }
}
