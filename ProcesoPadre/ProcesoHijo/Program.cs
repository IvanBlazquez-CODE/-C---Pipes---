using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.IO.Pipes;
namespace ProcesoHijo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (AnonymousPipeClientStream apc = new AnonymousPipeClientStream(PipeDirection.Out, args[0]))
            {
                using (StreamWriter sw = new StreamWriter(apc))
                {
                    sw.AutoFlush = true;
                    Console.Write("PROCESO 2. Letra:");
                    String c = Console.ReadLine();
                    while (c != "*")
                    {
                        sw.WriteLine(c);
                        
                        Console.Write("PROCESO 2. Letra:");
                        c = Console.ReadLine();
                    }
                    sw.WriteLine(c);
                    sw.Flush();
                }
                Console.WriteLine("PROCESO 2. FIN");
            }
        }
    }
}
