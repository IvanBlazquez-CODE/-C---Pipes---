using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FigurasGeometricas;
namespace WindowsFormsApplication1
{
    public partial class NuevoCirculo : Form
    {
        public NuevoCirculo()
        {
            InitializeComponent();
        }

        private void txtY_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x,y;
            float r;
            x=int.Parse(txtX.Text);
            y=int.Parse(txtY.Text);
            r=float.Parse(txtR.Text);
            CirculoDibujable cd = new CirculoDibujable(x, y, r, Color.Blue);
            Form1.coleccion.Add(cd);
            this.Dispose();
        }
    }
}
