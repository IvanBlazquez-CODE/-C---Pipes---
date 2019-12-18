using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseCuenta
{
    public class Cuenta
    {
        float debe, haber;
        public void Ingresar(float cant)
        {
            haber += cant;
        }
        public void Extraer(float cant)
        {
           
            debe += cant;
            if (GetSaldo()<0)
            {
                Exception ex = new Exception("Saldo negativo");
                throw ex;
            }
        }
        public float GetSaldo()
        {
            return haber - debe;
        }

        public override bool Equals(object obj)
        {   if (!(obj is Cuenta))
                return false;
            return this.GetSaldo() == ((Cuenta)obj).GetSaldo();
        }
    }
}
