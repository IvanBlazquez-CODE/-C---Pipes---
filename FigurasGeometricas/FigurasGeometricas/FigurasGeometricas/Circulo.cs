using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
  public  class Circulo : Figura
    {
        float Radio;
        public Circulo(int a, int b, float r): base(a, b)
        {
            Radio = r;
            
        }

        public override float Area()
        {
            return (float)Math.PI * Radio * Radio;
        }
        public override float Perimetro()
        {
            return (float)Math.PI * 2 * Radio;
        }

        public override void VerDatos()
        {
            Console.WriteLine("Radio:{0}", Radio); 
            base.VerDatos();
        }
      public float getRadio()
        {
            return Radio;
        }
    }
}
