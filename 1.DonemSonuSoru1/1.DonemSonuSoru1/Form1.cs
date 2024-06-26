using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.DonemSonuSoru1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c , k , r ,t;
            if(string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text)  || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                label6.Text = "Lütfen a,b ve c değerlerini boş bırakmayınız";
                return;
            }
            if(!double.TryParse(textBox1.Text , out a)  || !double.TryParse(textBox2.Text, out b) || !double.TryParse(textBox3.Text, out c))
            {
                label6.Text = "Lütfen a,b,c değerlerini geçerli değerler giriniz";
                return;               
            }
            if (a+b+c >=100 && a + b + c <= 100)
            {
                r = x(a, b, c);
                t = y(a, b, c);

                label4.Text = r.ToString();
                label5.Text = t.ToString();

                k = Math.Pow(r, t) - Math.Pow(t, r);

                label6.Text = k.ToString();
            }
            else
            {
                label6.Text = "Toplamları 100 ü geçmesin";
                return;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        double x (double a,double b , double c)
        {
            return (Math.Exp(a) + a) / (b + Math.Pow(c,5));
        }

        double y(double a,double b , double c)
        {
            return (Math.Sqrt(Math.Abs(a + Math.Sin(b))) / (Math.Pow(Math.Cos(c), 2)));
        }
    }
}
