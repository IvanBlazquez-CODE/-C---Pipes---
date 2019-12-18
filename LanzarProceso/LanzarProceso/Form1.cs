using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace LanzarProceso
{
    public partial class Form1 : Form
    {
        Process p;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.Arguments = txtDireccion.Text;
            info.FileName = "chrome.exe";
            p = new Process();
            p.StartInfo = info;
            p.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p.Kill();
          //  this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            p = new Process();
            string salida = Application.StartupPath + @"\output.txt";
            string path = System.Environment.GetFolderPath(Environment.SpecialFolder.System);
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = @"/c dir  "+ path + " >> \"" + salida + "\" && exit";
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.CreateNoWindow = true;   
            p.Start();
           MessageBox.Show(path);
            p.WaitForExit(10000); // 1 segundo de timeout
            if (!p.HasExited)
            {
                p.Kill(); // Finalizamos el proceso
             }
            else
            {
                   MessageBox.Show("El proceso ha finalizado");
            }

           
        }
    }
}
