using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funciones_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtNum.Text);
            txtFact.Text = Globales.factorial(num).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtNum.Text);
            int res;
            Globales.factorial(num, out res);
            txtFact.Text = res.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtNum.Text);
            Globales.factorial(ref num);
            txtFact.Text = num.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x;
            Globales.maximo(out x,1, 2,5,199,2,49);
            MessageBox.Show(x.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Globales.buscar(3,0).ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtNum.Text);
            txtFact.Text = Globales.factorialRec(num).ToString();
            Globales.factorial(3);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int max, min;
            float media;
            int[] tabla = { 1, 2, 3, 4, 5 };
            Globales.funcionEstadistica(tabla, out max, out min, out media);
            MessageBox.Show(String.Format("{0},{1},{2}", max.ToString(), min.ToString(), media.ToString()));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Globales.buscarLetra('s', "cese"))
                MessageBox.Show("Letra encontrada");
            else
                MessageBox.Show("Letra no encontrada");
        }
    }
}
