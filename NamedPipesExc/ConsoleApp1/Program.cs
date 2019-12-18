using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            NamedPipeClientStream npcs = new NamedPipeClientStream(".", "NamedPipesEx", PipeDirection.InOut);
            StreamWriter sw = new StreamWriter(npcs);
            StreamReader sr = new StreamReader(npcs);
                      npcs.Connect();
                        sw.AutoFlush = true; 
                        String c;
                        do
                        {
                            sw.WriteLine("Palabra: ");
                            String resp = sr.ReadLine();
                            Console.WriteLine(resp);
                            Console.WriteLine("Pedir más palabras?");
                             c= Console.ReadLine();
                        } while (c.ToUpper().CompareTo( "S")==0);
                        sw.WriteLine("Fin");
            
            Console.ReadLine();
            npcs.WaitForPipeDrain();
            npcs.Close();
                           

        }
    }
}
