using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowException
{
    class MuestraVaciaException : Exception
    {

        public MuestraVaciaException(string message) : base(message)
        {
            
        }

    }
}
