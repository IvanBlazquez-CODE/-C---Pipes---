using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;
namespace NamedPipesExc
{
    class Program
    {
        static void Main(string[] args)
        { int cont = 0;
            NamedPipeServerStream npss = new NamedPipeServerStream("NamedPipesEx", PipeDirection.InOut);
            StreamReader sr=new StreamReader(npss);
            StreamWriter sw = new StreamWriter(npss);
            npss.WaitForConnection();
                        sw.AutoFlush = true;
                        Console.WriteLine("Conexión entrante.");
                        String pal=sr.ReadLine();
                       
                        while(pal.ToUpper().CompareTo("FIN")!=0)
                        {
                            Console.WriteLine(pal);
                            String resp = Console.ReadLine();
                            sw.WriteLine(resp);
                            cont++;
                            pal = sr.ReadLine();
                        }
                  
              
           
            Console.WriteLine("SE han enviado {0} palabras", cont.ToString());
            Console.ReadLine();
            npss.WaitForPipeDrain();
            npss.Close();
        }
    }
}
