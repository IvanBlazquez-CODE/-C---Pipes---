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
namespace GestorProcesos
{
    public partial class frmProcess : Form
    {
        Process[] procesos;
        int i;
        public void LlenarProcesos()
        {
           procesos= Process.GetProcesses();
            lstProcesos.Items.Clear();
           foreach (Process p in procesos)
            {
                lstProcesos.Items.Add(p.ProcessName);
            }
        }

        public frmProcess()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void frmProcess_Load(object sender, EventArgs e)
        {
            LlenarProcesos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LlenarProcesos();
        }

        private void lstProcesos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                i = lstProcesos.SelectedIndex;
                String[] mensajes = {String.Format("Nombre de proceso:{0}\n", procesos[i].ProcessName),
                String.Format("PID:{0}\n", procesos[i].Id),
                String.Format("Prioridad: {0}\n", procesos[i].BasePriority),
                String.Format("Uso de Memoria:{0}\n", procesos[i].WorkingSet64),
                String.Format("Tiempo de CPU:{0}\n",procesos[i].TotalProcessorTime),
                String.Format("Módulo principal:{0}\n",procesos[i].MainModule.FileName)};
                txtPropiedades.Lines = mensajes;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Atención", "Desea parar el proceso", MessageBoxButtons.OKCancel);
            if (r==DialogResult.OK)
            {
                procesos[i].Kill();
            }
            else
            {
                MessageBox.Show("Se canceló la operación");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(txtPrograma.Text);
        }
    }
}
