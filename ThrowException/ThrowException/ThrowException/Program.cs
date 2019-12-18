using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowException
{
    class Program
    {
        static void Main(string[] args)
        {
            Estadistica e = new Estadistica();
            try
            {

                //e.add(7);
                //e.add(5);

                Console.WriteLine(e.getResultado().ToString());
                Console.ReadLine();
            }
            catch(MuestraVaciaException ex)
            {
              
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine(); 
            }

            short i;
           checked
            {
                for (i = 0; i <= short.MaxValue; i++)
                {
                    Console.WriteLine(i.ToString());
                }
            }
            Console.ReadLine(); 

        }
    }
}
