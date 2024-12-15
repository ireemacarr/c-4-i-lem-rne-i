using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4islem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2,sonuc;
            sayi1 = Convert.ToInt32(textBox2.Text);
            sayi2 = Convert.ToInt32(textBox1.Text);

            if (radioButton1.Checked)
            {
                sonuc = sayi1 + sayi2;


            }
            else if (radioButton2.Checked)
            {
                sonuc = sayi1 / sayi2;

            }
            else if (radioButton3.Checked)
            {
                sonuc = sayi1 - sayi2;

            }
            else 
            {
                sonuc = sayi1* sayi2;

            }
            label4.Text = sonuc.ToString();

            }

        }
    }

