using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClaseCuenta;
namespace ProbarCuenta
{
    public partial class Form1 : Form
    {
        Cuenta c,d;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InicializarCuenta(out c);
            InicializarCuenta(out d);
        }

        private void button1_Click(object sender, EventArgs e)
        {    if(radioButton1.Checked)
                c.Ingresar(float.Parse(textBox1.Text));
            else if (radioButton2.Checked)
                {
                d.Ingresar(float.Parse(textBox1.Text));
                }
              
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                c.Ingresar(float.Parse(textBox1.Text));
            else if (radioButton2.Checked)
            {
                d.Ingresar(float.Parse(textBox1.Text));
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
                MessageBox.Show(String.Format("Saldo:{0}", c.GetSaldo().ToString()));
            else if (radioButton2.Checked)
            {
                MessageBox.Show(String.Format("Saldo:{0}", d.GetSaldo().ToString()));
            }

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (d.Equals(c))
                MessageBox.Show("son iguales");
            else
                MessageBox.Show("son distintas");
        }

        private void InicializarCuenta ( out Cuenta c)
        {
            c = new Cuenta();
        }
    }
}
