using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sınav_Durumu_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double snv1, snv2, snv3, ort;
            snv1 = Convert.ToDouble(textBox3.Text);
            snv2 = Convert.ToDouble(textBox4.Text);
            snv3 = Convert.ToDouble(textBox5.Text);
            ort = (snv1 + snv2 + snv3) / 3;
            ortlabel.Text = ort.ToString(0.00);
            listBox1.Items.Add("Ad: " + textBox1.Text);
            listBox1.Items.Add("Soyad: " + textBox2.Text);
            if (ort >= 60) 
            {
                listBox1.Items.Add("Dersten Geçtiniz");
            }
            else
            {
                listBox1.Items.Add("Dersten Kaldınız");
            }
        }
    }
}
