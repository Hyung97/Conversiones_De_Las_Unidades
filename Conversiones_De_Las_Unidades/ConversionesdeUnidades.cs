using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones_De_Las_Unidades
{
    class ConversionesdeUnidades
    {
        double[][] valores = new double[5][] {
            //Monedas 0
   new double[]{1, 61.65, 6.92, 1.33, 796.500, 3409.97, 0.93, 900.007, 1190.93, 7.63550, 112.18, 196.88, 18.59, 63.57, 8.75, 38.07, 3.38, 6526.30, 1, 34.19},

           //Longitud 1
            new double[]{0.1, 0.01, 0.04, 3.28*10-3, 1.09*10-3, 1.99*10-4, 1, 10-6, 6.21*10-7, 5.4*10-7, 2.07*10-7},
    
           //Peso 2
             new double[]{1,1000,1000000,28.349,453.59,907.18474,11339.809,10,100,0.1,0.01,0.001},
            
             //Temperatura 3
                   new double[]{33.8, 1, 274.15, 493.47},

                   //Almacenamiento
                   new double[]{1, 8, 8000, 8e+6, 8e+9, 8e+12, 8e+15}
        };

        public double convertir(double cantidad, int de, int a, int opcion)
        {
            return valores[opcion][a] / valores[opcion][de] * cantidad;
        }
    }
}
