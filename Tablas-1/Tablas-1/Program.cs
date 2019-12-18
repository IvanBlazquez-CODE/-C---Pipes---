using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablas_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tabla;
            int i;
            CargarTabla(out tabla);
            for (i=0;i<tabla.Length;i++)
            {
                Console.WriteLine("tabla[{0}]", i);
                tabla[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Posicion  Contenido");
            for(i=0;i<tabla.Length;i++)
            {
                Console.WriteLine("{0,8}  {1,9}", i, tabla[i]);
            }
            Console.ReadLine();
        }
        static void CargarTabla(out int []tabla )
        {
            Console.WriteLine("Nº Elementos");
            int  i = int.Parse(Console.ReadLine());
            tabla = new int[i];
        }
    }
}
