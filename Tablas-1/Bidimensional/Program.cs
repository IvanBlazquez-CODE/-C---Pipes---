using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bidimensional
{
    class Program
    {   public static void funcion(int []tabla)
        {
            int suma;
            suma = 0;
            for (int i = 0; i < tabla.Length; i++)
                suma += tabla[i];
            Console.WriteLine(suma);
        }

        public static void funcionB(int[,] tabla)
        {
            int i, j;
            for (i = 0; i < tabla.GetLength(0); i++)
            {
                for (j = 0; j < tabla.GetLength(1); j++)
                {
                    Console.Write("{0} ", tabla[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int i, j;
            int[][] tabla=new int [3][];
            for (i = 0; i < 3; i++)
                tabla[i] = new int[i+1];
                for (i = 0; i <3; i++)
                    for (j = 0; j <tabla[i].Length; j++)
                        tabla[i][ j] = j;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j <tabla[i].Length; j++)
                    Console.Write("{0} ", tabla[i][j]);
                Console.WriteLine();
            }
            int a, b, c, d;
            a = b = c = d = 1;
            funcion(new int[4] { a, b, c,d});
            funcionB(new int[,] {{ a, b },{ c, d } });
            Console.ReadLine();
        }
    }
}
