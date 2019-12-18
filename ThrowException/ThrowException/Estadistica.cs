using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowException
{
    class Estadistica
    {
        int cont, sum;
        public float getResultado()
        {   if(cont==0)
            {
                throw new MuestraVaciaException("La muestra está vacía");
            }
            return (float)sum / cont;
        }
        public void add(int num)
        {
            sum += num;
            cont++;
        }
        public override string ToString()
        {
            return String.Format("{0}/{1}", sum.ToString(), cont.ToString());
        }
    }
}
