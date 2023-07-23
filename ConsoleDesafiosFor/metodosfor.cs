using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleDesafiosFor
{
    internal class metodosfor
    {
        public static bool Eprimo(int nmrPrimo)
        {

            if (nmrPrimo <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(nmrPrimo); i++)
            {
                if (nmrPrimo % i == 0)
                    return false;
            }

            return true;
        }
    }


    }
}
