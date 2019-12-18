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
    public partial class Form1 : Form
    {
        public static List<Dibujable> coleccion = new List<Dibujable>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevoCirculo f=new NuevoCirculo();
            f.ShowDialog();
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (Dibujable f in coleccion)
                f.dibujar(e.Graphics);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NuevoRectangulo f = new NuevoRectangulo();
            f.ShowDialog();
            this.Invalidate();
        }

      
    }
}
