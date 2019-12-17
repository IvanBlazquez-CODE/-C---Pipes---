using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Cliente Esperando");
            Boolean mutexcreado;
            Mutex mt = new Mutex(false, "nuevomutex", out mutexcreado);
            if (!mutexcreado)
            {
                mt = Mutex.OpenExisting("nuevomutex");
                mt.WaitOne();
                mt.ReleaseMutex();
            }
           Console.WriteLine("Cliente Leyendo");
           StreamReader sr = new StreamReader("D:\\fichero.txt");
           String pal = sr.ReadLine();
            while (pal.CompareTo("$")!=0)
            {
                Console.WriteLine(pal);
                pal = sr.ReadLine();
            }
            sr.Close();
            Console.ReadLine();
        }
    }
}
