using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcesosListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void LlenarListView()
        {
            String[] procesos = { "uno", "dos", "tres" };
            foreach (String nom in procesos)
                {
                ListViewItem it=listView1.Items.Add(nom);
                it.SubItems.Add("1223");
                it.SubItems.Add("2332");
                it.SubItems.Add("8");
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LlenarListView();
        }
    }
}
