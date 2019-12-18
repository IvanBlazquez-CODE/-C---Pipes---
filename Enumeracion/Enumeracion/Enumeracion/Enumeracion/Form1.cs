using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enumeracion
{
    public enum dias
    {
        lunes, martes, miercoles, jueves, viernes
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dias d;
            for (d=dias.lunes;d<=dias.viernes;d++)
            {
                comboBox1.Items.Add(d.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            
            if ( int.TryParse(textBox1.Text, out num))
            {
                MessageBox.Show("Correcto");
            }
            else
            {
                MessageBox.Show("Error");
            }


        }
    }
}
