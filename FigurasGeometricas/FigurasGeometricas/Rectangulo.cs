using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
   public class Rectangulo:Figura
    {
      float Base, Altura;
       public float ValorBase
       {
           get
           {
               return Base;
           }
        }
       public float ValorAltura
       {
           get
           {
               return Altura;
           }
       }
       public Rectangulo(int a, int b,float ba,float h):base(a,b)
        {
            Base = ba;
            Altura = h;
        }
        public override float Area()
        {

            return Base * Altura;
        }
        public override float Perimetro()
        {
            return 2 * Base + 2 * Altura;
        }
        public override void VerDatos()
        {
            Console.WriteLine("Base:{0}", Base);
            Console.WriteLine("Altura:{0}", Altura);
            base.VerDatos();
        }
    }
}
