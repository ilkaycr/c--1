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

namespace _1.DönemSonuSoru2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j, n;

            if (string.IsNullOrWhiteSpace(textBox1.Text) || !int.TryParse(textBox1.Text, out n))
            {
                label1.Text = "Lütfen geçerli bir n değeri girin.";
                return;
            }

            int[,] a = new int[n + 1, n + 1];
            string satir1 = "";
            int ciftKupToplami = 0;
            int tekKareToplami = 0;

            for (i = 1; i <= n; i++)
            {
                satir1 = "";
                for (j = 1; j <= n; j++)
                {
                    string input = Microsoft.VisualBasic.Interaction.InputBox("A(" + i + "," + j + ") elemanını giriniz", "A Matrisi", "", 100, 100);
                    int value;

                    // Girişin geçerli olup olmadığını kontrol et
                    if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out value))
                    {
                        MessageBox.Show("Geçersiz giriş, lütfen tekrar deneyin.");
                        j--; // Geçerli olmayan girişi yeniden dene
                        continue;
                    }

                    a[i, j] = value;
                    satir1 += a[i, j].ToString() + "       ";

                    // Çift sayının küpünü toplama ekle
                    if (value % 2 == 0)
                    {
                        ciftKupToplami += value * value * value;
                    }
                    // Tek sayının karesini toplama ekle
                    else
                    {
                        tekKareToplami += value * value;
                    }
                }
                listBox1.Items.Add(satir1);
            }

            // Sonuçları etiketlere yazdır
            label2.Text = "Tek sayıların kareleri toplamı: " + tekKareToplami.ToString();
            label3.Text = "Çift sayıların küpleri toplamı: " + ciftKupToplami.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
