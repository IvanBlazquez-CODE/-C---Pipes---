using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace InstanciaUnica
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {   bool mutexCreado = false;
          Mutex miMutex = new Mutex(true, "nombreUnicoParaEstaAplicacion", out mutexCreado);
          if (mutexCreado)
          {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
               miMutex.ReleaseMutex();
            }
        }
    }
}
