using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Racionales.Model;

namespace Racionales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonmult_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToInt32(textBox1.Text);
            double d1 = Convert.ToInt32(textBox2.Text);
            double n2 = Convert.ToInt32(textBox3.Text);
            double d2 = Convert.ToInt32(textBox4.Text);

            Racional r1 = new Racional(n1, d1);
            Racional r2 = new Racional(n2, d2);

            Racional producto = r1.multiplicar(r2);

            textBox5.Text = producto.getA().ToString();
            textBox6.Text = producto.getB().ToString();
            textBox7.Text = "x";

        }

        private void buttondividir_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToInt32(textBox1.Text);
            double d1 = Convert.ToInt32(textBox2.Text);
            double n2 = Convert.ToInt32(textBox3.Text);
            double d2 = Convert.ToInt32(textBox4.Text);

            Racional r1 = new Racional(n1, d1);
            Racional r2 = new Racional(n2, d2);

            Racional division = r1.dividir(r2);

            textBox5.Text = division.getA().ToString();
            textBox6.Text = division.getB().ToString();
            textBox7.Text = "÷";
        }

        private void buttonEquiv_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToInt32(textBox1.Text);
            double d1 = Convert.ToInt32(textBox2.Text);
            double n2 = Convert.ToInt32(textBox3.Text);
            double d2 = Convert.ToInt32(textBox4.Text);


            if (n1 / d1 == n2 / d2)
            {
                textBox8.Text = "SI";
            }
            else
            {
                textBox8.Text = "NO";
            }
        }


    }
}
