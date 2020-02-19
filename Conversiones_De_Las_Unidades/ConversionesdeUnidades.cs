using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones_De_Las_Unidades
{
    class ConversionesdeUnidades
    {
        double[][] valores = new double[4][] {
            //Monedas 0
   new double[]{1,26.81,119.26,7.63,1.05,15.48,8.79,2679.76,6.35,639.96,3.25,25.30,6.91,533.51,4794.52,3.10,44.72,1.00,21.40,1.28,0.68,4.04,1.01,62.65,6.26,1.31,7.11,63.16,7.77},

           //Longitud 1
            new double[]{0.1, 0.01, 0.04, 3.28*10-3, 1.09*10-3, 1.99*10-4, 1, 10-6, 6.21*10-7, 5.4*10-7, 2.07*10-7},
    
           //Peso 2
             new double[]{1,1000,1000000,28.349,453.59,907.18474,11339.809,10,100,0.1,0.01,0.001},
            
             //Temperatura 3
                   new double[]{33.8, 1, 274.15, 493.47}
        };

        public double convertir(double cantidad, int de, int a, int opcion)
        {
            return valores[opcion][a] / valores[opcion][de] * cantidad;
        }
    }
}
