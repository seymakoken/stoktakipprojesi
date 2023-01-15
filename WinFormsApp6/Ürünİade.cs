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
    public partial class Ürünİade : Form
    {
        public Ürünİade()
        {
            InitializeComponent();
        }
        public int IadeUrunMiktarı = 0;
        public string UrunuIadeKisi = "a";
        public int IadeUrunID = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(textBox1.Text, out int sayi) && textBox1.Text.Length > 0 && textBox1.Text != "-")
            {
                MessageBox.Show($"Geçersiz bir sayı girdiniz: {textBox1.Text}");
                textBox1.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(textBox3.Text, out int sayi) && textBox3.Text.Length > 0 && textBox3.Text != "-")
            {
                MessageBox.Show($"Geçersiz bir sayı girdiniz: {textBox3.Text}");
                textBox3.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StokArama secimSayfasi = new StokArama();

            IadeUrunMiktarı = int.Parse(textBox1.Text);
            IadeUrunID = int.Parse(textBox3.Text);
            UrunuIadeKisi = textBox2.Text;
            secimSayfasi.ShowDialog();
            this.Hide();
        }
    }
}
