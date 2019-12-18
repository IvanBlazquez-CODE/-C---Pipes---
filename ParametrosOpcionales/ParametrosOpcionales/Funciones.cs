using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametrosOpcionales
{
    public class Funciones
    {

        public static int suma(int a , int b=0)
        {
            return a + b;
        }
        public static int suma(params int []numeros)
        {
            int suma = 0;
            for (int i = 0; i < numeros.Length; i++)
                suma += 2*numeros[i];
            return suma;
        }
        public static int suma(int a)
        {
            return a ;
        }
    }
}
