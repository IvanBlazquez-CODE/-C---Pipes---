using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
namespace EjemploMutex
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("d:\\fichero.txt");
            Mutex mt = new Mutex(false, "nuevomutex");
            mt.WaitOne();
            String pal;
             Console.WriteLine("Introduce palabra");
             pal = Console.ReadLine();
             while(pal.CompareTo("$")!=0)
             {
                 sw.WriteLine(pal);
                 Console.WriteLine("Introduce palabra");
                 pal = Console.ReadLine();
             }
             sw.WriteLine("$");
             sw.Close();
            Console.ReadLine();
            mt.ReleaseMutex();
            Console.ReadLine();
         
        }
    }
}
