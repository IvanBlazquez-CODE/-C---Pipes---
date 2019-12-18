using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploClaseCuenta
{
    public partial class Form1 : Form
    {
        Cuenta c = new Cuenta("Ejemplo");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.Ingresar(float.Parse(txtCantidad.Text));
            txtSaldo.Text = c.getSaldo().ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.Extraer(float.Parse(txtCantidad.Text));
            txtSaldo.Text=c.getSaldo().ToString();
        }
    }
}
