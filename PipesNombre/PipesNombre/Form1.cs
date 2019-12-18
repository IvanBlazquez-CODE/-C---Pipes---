using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Pipes;
using System.IO;
namespace PipesNombre
{
    public partial class Form1 : Form
    {
        StreamReader sr;
        int WM_MENSAJE;
        NamedPipeServerStream np ;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            np = new NamedPipeServerStream("pipeotro", PipeDirection.In);
            np.WaitForConnection();
            sr= new StreamReader(np);
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
          WM_MENSAJE=  Funciones.FuncionesAPI.RegisterWindowMessage("WM_MENSAJE");
        }
        protected override void WndProc(ref Message m)
        {  if (m.Msg == WM_MENSAJE)
            {
                String pal = sr.ReadLine();
                listBox1.Items.Add(pal);
            }
            else
            { base.WndProc(ref m); }
        }

       
    }
}
