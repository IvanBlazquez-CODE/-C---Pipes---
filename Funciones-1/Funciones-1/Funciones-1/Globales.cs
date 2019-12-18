using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones_1
{
    class Globales
    {
        public static int factorial(int x)
        {
            int res = 1;
            int i;
            for (;x>1 ;x--)
            {
                res *= x;
            }
            return res;
        }

        public static void factorial(int x, out int res)
        {
            res = 1;
            int i;
            for (i = 2; i <= x; i++)
            {
                res *= i;
            }
        }

        public static void factorial(ref int x)
        {
            int res = 1;
            int i;
            for (i = 2; i <= x; i++)
            {
                res *= i;
            }
            x = res;
        }
        public static void  maximo(out int res,params int [] num)
        {
            res = num[0];
            int i;
            for (i = 0; i < num.Length; i++)
                if (num[i] > res) res = num[i];
         
        }
        public static int buscar(int x, int pos=0,params int []num)
        {
            int i;
            for (i = pos; i < num.Length; i++)
            {
                if (num[i] == x) return i;
            }

            return -1;
        }
        public static int suma(int x=1,int y=1)
        {
            return x + y;
           
        }
        public static int factorial(int num,int max=10)
        {
            int res = 1;
            int i;
            for (i = 2; i <= num && res<=max; i++)
            {
                res *= i;
            }
            return res;
        }
        public static int factorialRec(int x)
        {
            if (x == 0 || x == 1)
                return 1;
            else
                return x * factorialRec(x - 1);
        }

        public static void funcionEstadistica(int []tabla,out int max, out int min, out float media)
        {
            int i,tam;
            max = 0;
            min = 0;
            media = tabla[0];
            tam = tabla.Length;
            for (i=1;i<tam;i++)
            {
                if (tabla[i] > tabla[max])
                    max = i;
                else if (tabla[i] < tabla[min])
                    min = i;
                media += tabla[i]; 

            }
            max = tabla[max];
            min = tabla[min];
            media = media /(float) tam;
        }

        public static bool buscarLetra(char letra, String frase)
        {
            if (frase.Length==1)
            {
                if (letra == frase[0])
                    return true;
                else
                    return false;
            }
            else
            {
                return letra == frase[0] || buscarLetra(letra, frase.Substring(1));
            }

        }
    }   
}
