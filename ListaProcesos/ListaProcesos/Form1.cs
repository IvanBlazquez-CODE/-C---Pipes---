using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace ListaProcesos
{   
    public partial class Form1 : Form
    {
        Process[] procesos;
        int i;
        private void LlenarProcesos()
        {
            procesos = Process.GetProcesses();
            int index;
            for (index = 0; index < procesos.Length && index < lstProcesos.Items.Count; index++)
            {
                if (procesos[index].ProcessName.CompareTo(lstProcesos.Items[index].ToString()) != 0)
                {
                    lstProcesos.Items[index] = procesos[index].ProcessName;
                }
            }



            while (index < procesos.Length)
            {
                lstProcesos.Items.Add(procesos[index].ProcessName);
                index++;
            }
            while (index < lstProcesos.Items.Count)
            {
                lstProcesos.Items.RemoveAt(index);
                index++;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LlenarProcesos();
            timer1.Start();
        }

        private void LstProcesos_DoubleClick(object sender, EventArgs e)
        {
            
                try
                {
                    i = lstProcesos.SelectedIndex;
                    String[] mensajes = {String.Format("Nombre de proceso:{0}\n", procesos[i].ProcessName),
                    String.Format("PID:{0}\n", procesos[i].Id),
                     String.Format("Prioridad: {0}\n", procesos[i].BasePriority),
                    String.Format("Uso de Memoria:{0}\n", procesos[i].WorkingSet64),
                    String.Format("Tiempo de CPU:{0}\n",procesos[i].TotalProcessorTime),
                    String.Format("Módulo principal:{0}\n",procesos[i].MainModule.FileName)
                };
                    txtInfo.Lines = mensajes;
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
           LlenarProcesos();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
      
        }

        private void Button1_Click(object sender, EventArgs e)
        {try
            {
                procesos[i].Kill();
                LlenarProcesos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
