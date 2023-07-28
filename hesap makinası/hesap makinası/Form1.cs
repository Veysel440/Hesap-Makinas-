using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesap_makinası
{
    public partial class Form1 : Form
    {
        double ilksayı, ikincisayı, hafıza, sonuç;
        string islem;
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tb1.Text = "";
            ilksayı = 0; ikincisayı = 0; sonuç = 0;

        }

        private void sayıolay(object sender, EventArgs e)
        {
            Button btn = (Button)sender;


            tb1.Text += btn.Text;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            sonuç=Convert.ToDouble(tb1.Text) * - 1;
            tb1.Text = Convert.ToString(sonuç);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            hafıza = hafıza + Convert.ToDouble(tb1.Text);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            hafıza = hafıza - Convert.ToDouble(tb1.Text);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            tb1.Text = Convert.ToString(hafıza);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if(islem=="+")
            {
                sonuç = ilksayı + Convert.ToDouble(tb1.Text);  
            }
            if (islem == "-")
            {
                sonuç = ilksayı - Convert.ToDouble(tb1.Text);
            }
            if (islem == "*")
            {
                sonuç = ilksayı * Convert.ToDouble(tb1.Text);
            }
            if (islem == "/")
            {
                sonuç = ilksayı / Convert.ToDouble(tb1.Text);
            }
            tb1.Text = Convert.ToString(sonuç);

        }

        private void işlem(object sender, EventArgs e)
        {
            ilksayı = Convert.ToDouble(tb1.Text);
            tb1.Text = "";
            islem = (sender as Button).Text; 


        }
    }
}
