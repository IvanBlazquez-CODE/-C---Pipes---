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
namespace Procesos
{
    public partial class frmProcesos : Form
    {
        Process[] procesos;
        public frmProcesos()
        {
            InitializeComponent();
        }

        private void frmProcesos_Load(object sender, EventArgs e)
        {
            LlenarProcesos();
            timer1.Start();
        }

        private void LlenarProcesos()
        {
            int i ;
            procesos = Process.GetProcesses();
            for (i=0;i<lstProcesos.Items.Count&&i<procesos.Length;i++ )
            {
                if (lstProcesos.Items[i].ToString().CompareTo(procesos[i].ProcessName) != 0)
                    lstProcesos.Items[i] = procesos[i].ProcessName;
            }
            if (i<lstProcesos.Items.Count)
            {
                for (; i < lstProcesos.Items.Count;i++)
                    lstProcesos.Items.RemoveAt(i);
            }
            else if(i<procesos.Length)
            {
                for(;i<procesos.Length;i++)
                {
                    lstProcesos.Items.Add(procesos[i].ProcessName);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LlenarProcesos();
        }

        private void lstProcesos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int i = lstProcesos.SelectedIndex;
                String[] mensajes = {String.Format("Nombre de proceso:{0}\n", procesos[i].ProcessName),
                String.Format("PID:{0}\n", procesos[i].Id),
                String.Format("Prioridad: {0}\n", procesos[i].BasePriority),
                String.Format("Uso de Memoria:{0}\n", procesos[i].WorkingSet64),
                String.Format("Tiempo de CPU:{0}\n",procesos[i].TotalProcessorTime),
                String.Format("Módulo principal:{0}\n",procesos[i].MainModule.FileName)};
                txtInfo.Lines = mensajes;
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void btnKill_Click(object sender, EventArgs e)
        { try
            {
                int i = lstProcesos.SelectedIndex;
                procesos[i].Kill();
            }
            catch(System.IndexOutOfRangeException ex)
            {
                MessageBox.Show("No se seleccionó ningún proceso");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
