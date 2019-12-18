using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;
using System.Diagnostics;
using Funciones;
using System.Windows.Forms;

namespace Hijo
{
    class Program
    {  static int WM_MENSAJE;
        static void Main(string[] args)



        {
            WM_MENSAJE = FuncionesAPI.RegisterWindowMessage("WM_MENSAJE");
           
            NamedPipeClientStream npcs = new NamedPipeClientStream(".", "pipeotro", PipeDirection.Out,PipeOptions.None);
            npcs.Connect();
            StreamWriter sw = new StreamWriter(npcs);
            sw.AutoFlush=true;
            PipeSecurity ps = new PipeSecurity();
            ps.AddAccessRule(new PipeAccessRule("Usuarios del Dominio", PipeAccessRights.ReadWrite, System.Security.AccessControl.AccessControlType.Allow));
            NamedPipeServerStream nprss = new NamedPipeServerStream("receptorpipe",PipeDirection.In,1,PipeTransmissionMode.Byte,PipeOptions.None,0,0,ps);
            nprss.WaitForConnection();
            StreamReader sr = new StreamReader(nprss);
            IntPtr h = Process.GetProcessesByName("PipesNombre")[0].MainWindowHandle;
            Console.WriteLine("Conectado {0}", nprss.GetImpersonationUserName());
            Console.WriteLine("Palabra: ");
            String s = sr.ReadLine();
            while(s!="")
             {  
               FuncionesAPI.PostMessage(h, WM_MENSAJE,IntPtr.Zero, IntPtr.Zero);
                sw.WriteLine(s);
                Console.WriteLine("Palabra: ");
                s = sr.ReadLine();
            }
         
        }
    }
}
