using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    public abstract class Figura
    {
        private int x, y;
        public abstract float Area();
        public abstract float Perimetro();

        public Figura (int a, int b)
        {
            x = a;
            y = b;
        
        }
        
        public int CoordX
        {
            get
            {
                return x;
            }
            
        }

        public int CoordY
        {
            get
            {
                return y;
            }
        }

        public virtual void VerDatos()
            {
                Console.WriteLine("X:{0}", x);
                Console.WriteLine("Y:{0}", y);
                Console.WriteLine("Area:{0}", Area());
                Console.WriteLine("Perímetro:{0}", Perimetro());
            }

    }
}
