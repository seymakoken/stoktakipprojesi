using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp6
{
    public partial class ÜrünEkle : Form
    {
        public ÜrünEkle()
        {
            InitializeComponent();
        }

        private void StokEkle_Load(object sender, EventArgs e)
        {

        }
        public int EklenenUrunMiktarı = 0;
        public string EklenenUrunAdi = "a";

        private void button1_Click(object sender, EventArgs e)
        {
            StokArama secimSayfasi = new StokArama();

            EklenenUrunMiktarı = int.Parse(textBox1.Text);
            EklenenUrunAdi = textBox2.Text;
            secimSayfasi.ShowDialog();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(textBox1.Text, out int sayi) && textBox1.Text.Length > 0 && textBox1.Text != "-")
            {
                MessageBox.Show($"Geçersiz bir sayı girdiniz: {textBox1.Text}");
                textBox1.Clear();
            }
        }
    }
}
