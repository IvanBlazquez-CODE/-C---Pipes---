using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EjemploSemaforos
{
    class Program
    {
        static void Main(string[] args)
        {
            Semaphore s = new Semaphore(4, 4, "semaforo");
            Console.WriteLine("Semáforo iniciado");
            Console.ReadLine();
        }
    }
}
