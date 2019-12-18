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
    public partial class NuevoRectangulo : Form
    {
        public NuevoRectangulo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, y;
            float b, h;
            x = int.Parse(txtX.Text);
            y = int.Parse(txtY.Text);
            b = float.Parse(txtB.Text);
            h = float.Parse(txtH.Text);
            RectanguloDibujable rd=new RectanguloDibujable(x,y,(int)b,(int)h,Color.Magenta);
            Form1.coleccion.Add(rd);
            this.Dispose();
        }
    }
}
