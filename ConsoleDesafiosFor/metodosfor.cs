using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
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



        public static void Troca(int[] g, int primeiro)
        {
            int aux;
            aux = g[primeiro];
            g[primeiro] = g[primeiro + 1];
            g[primeiro + 1] = aux;
        }

        public static void bubbleSort(int[] ArrX)
        {

            for(int i = 1; i < ArrX.Length; i++)
            {
                for(int j = 0; j < ArrX.Length - 1; j++)
                {
                    if (ArrX[j] > ArrX[j + 1])
                    {
                        Troca(ArrX,j);
                    }
                }
            }


        }





    }


    
}
