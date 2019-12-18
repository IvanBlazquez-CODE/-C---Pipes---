using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Pipes;
using System.IO;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            NamedPipeClientStream npcs = new NamedPipeClientStream("192.168.37.150", "receptorpipe", PipeDirection.Out);
            npcs.Connect();
            StreamWriter sw = new StreamWriter(npcs);
            sw.AutoFlush = true;
            Console.WriteLine("Palabra: ");
            String pal = Console.ReadLine();
            while(pal.CompareTo("/fin")!=0)
            {
                sw.WriteLine(pal);
            Console.WriteLine("Palabra: ");
             pal = Console.ReadLine();
            }
            sw.Close();
            npcs.Close();

        }
    }
}
