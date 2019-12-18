using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Pipes;
using System.IO;
namespace PipesAnonimos
{
    class Program
    {
        static void Main(string[] args)
        {   //Creo un pipe de salida asociado al ID que me pasa el padre como parámetro
            using (AnonymousPipeClientStream apcs = new AnonymousPipeClientStream(PipeDirection.Out, args[0]))
            {   //Creamos el stream asociado al pipe
                using (StreamWriter sw = new StreamWriter(apcs))
                {
                    sw.AutoFlush = true; //Los caracteres se envían al momento.
                    ConsoleKeyInfo c = new ConsoleKeyInfo();
                    do
                    { if(Console.KeyAvailable)  //Si hemos pulsado una tecla
                        {
                            c = Console.ReadKey(); //obtener tecla pulsada
                            sw.Write(c.KeyChar);  //enviarla por el pipe
                        }

                    }while( c.Key!= ConsoleKey.Escape);
                    sw.Write('*');//Al terminar enviar **'
                    apcs.WaitForPipeDrain();  //Esperar a consumir el último caracter
                }
            }
        }
    }
}
