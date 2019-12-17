using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Semaforofrm
{
    public partial class Form1 : Form
    {
        Semaphore s;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s.Release();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            s = Semaphore.OpenExisting("semaforo");
            s.WaitOne();
        }
    }
}
