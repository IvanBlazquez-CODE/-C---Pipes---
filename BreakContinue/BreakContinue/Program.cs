using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakContinue
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            for (int i = 0; i<10;i++)
            {
                if (i %2!=0)
                       Console.WriteLine(i.ToString());
               
            }
            Console.ReadLine();
        }
    }
}
