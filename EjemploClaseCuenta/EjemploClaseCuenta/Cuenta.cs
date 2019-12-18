using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploClaseCuenta
{
    class Cuenta
    {   private String nombre;
        private float debe, haber;
        public Cuenta(String nom)
        {
            
            nombre = nom;
        }
        public void Ingresar(float cant)
        {
            haber += cant;
        }
        public void Extraer(float cant)
        {
            debe += cant;  
        }
        public float getSaldo()
        {
            return haber-debe;
        }
    }
}
