using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsApp6
{
    public partial class GirisSayfasi : Form
    {
        public GirisSayfasi()
        {
            InitializeComponent();
        }
        string kullaniciadi = "admin";
        string sifre = "123";
        private void button1_Click(object sender, EventArgs e)
        {
            StokArama fr4 = new StokArama();

            string degisken = textBox1.Text;
            string degisken2 = textBox2.Text;
            if (degisken == kullaniciadi & degisken2 == sifre)
            {
                fr4.ShowDialog();
                this.Hide();
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                MessageBox.Show("kullanıcı adı veya şifreniz hatalı - tekrar deneyin");
            }
        }
    }
}
