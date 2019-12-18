using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigurasGeometricas;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> lista = new List<Figura>();
            lista.Add(new Circulo(1, 1, 10));
            lista.Add(new Rectangulo(1,1,10,12));
            foreach(Figura f in lista)
            {
                f.VerDatos();
            }
            Console.ReadLine();
        }
    }
}
