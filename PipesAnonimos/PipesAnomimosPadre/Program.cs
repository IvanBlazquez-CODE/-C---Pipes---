using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;
using System.Diagnostics;
namespace PipesAnomimosPadre
{
    class Program
    {
        static void Main(string[] args)
        {   //Creo un pipeserver con Handle heredable.
            using (AnonymousPipeServerStream anps = new AnonymousPipeServerStream(PipeDirection.In, HandleInheritability.Inheritable))
            {
                Process p = new Process();
                p.StartInfo.FileName = @"..\..\..\PipesAnonimos\bin\Debug\PipesAnonimos.exe";
                p.StartInfo.Arguments = anps.GetClientHandleAsString();
                p.StartInfo.UseShellExecute = false;//Para que usen la misma instancia del cmd
                p.Start();
                anps.DisposeLocalCopyOfClientHandle();
                using (StreamReader sr = new StreamReader(anps))
                {
                    char c = (char)sr.Read();
                    while(c!='*')
                    {
                        Console.Write(c);
                        c = (char)sr.Read();
                    }
                    sr.Close();
                }
               
                Console.ReadLine();
            }
        }
    }
}
