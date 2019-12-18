using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO.Pipes;
using System.IO;
namespace ProcesoPadre
{
    class Program
    {
        static void Main(string[] args)
        {
            using (AnonymousPipeServerStream pss = new AnonymousPipeServerStream(PipeDirection.In, System.IO.HandleInheritability.Inheritable))
            {
                Process hijo = new Process();
                hijo.StartInfo.FileName = "..\\..\\..\\ProcesoHijo\\bin\\Debug\\ProcesoHijo.exe";
                hijo.StartInfo.UseShellExecute = false;
                hijo.StartInfo.Arguments = pss.GetClientHandleAsString();
                hijo.Start();
                pss.DisposeLocalCopyOfClientHandle();
                StreamReader sr = new StreamReader(pss);
                String  vble = "";
                vble = sr.ReadLine();
                string res = "";
                while(vble!="*")
                {
                    res += vble;
                    vble = sr.ReadLine();
                }
                
                Console.WriteLine("PROCESO1: Se recibió el mensaje: {0}", res);
                Console.WriteLine("PROCESO 1. FIN");
                Console.ReadLine();
                sr.Close();
            }

        }
    }
}
