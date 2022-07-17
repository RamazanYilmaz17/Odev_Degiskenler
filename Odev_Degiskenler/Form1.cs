using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_Degiskenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kisa, uzun, alan, cevre;
            kisa = Convert.ToInt16(TxtKisa.Text);
            uzun = Convert.ToInt16(TxtUzun.Text);
            alan = kisa * uzun;
            cevre = kisa + uzun + kisa + uzun;
            LblAlan1.Text = alan.ToString();
            LblCevre1.Text = cevre.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double yaricap, pi, alan, cevre;
            yaricap = Convert.ToDouble(TxtYaricap.Text);
            pi = 3.14;
            alan = pi * (yaricap * yaricap);
            cevre = (2 * pi) * yaricap;
            LblAlan2.Text = alan.ToString();
            LblCevre2.Text = cevre.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double not1, not2, not3, ortalama;
            not1 = Convert.ToDouble(TxtNot1.Text);
            not2 = Convert.ToDouble(TxtNot2.Text);
            not3 = Convert.ToDouble(TxtNot3.Text);
            ortalama = (not1 + not2 + not3) / 3;
            LblOrtalama.Text = ortalama.ToString("0.00");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sayi3, toplama, fark, carpma;
            sayi1 = Convert.ToInt16(TxtSayi1.Text);
            sayi2 = Convert.ToInt16(TxtSayi2.Text);
            sayi3 = Convert.ToInt16(TxtSayi3.Text);
            toplama = sayi1 + sayi2 + sayi3;
            fark = sayi1 + sayi2 + sayi3;
            carpma = sayi1 * sayi2 * sayi3;
            listBox1.Items.Add("Toplam: " + toplama);
            listBox1.Items.Add("Fark: " + fark);
            listBox1.Items.Add("Çarpım: " + carpma);
        }
    }
}
