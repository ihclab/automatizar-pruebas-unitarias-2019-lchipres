using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.math;

namespace AutomatizarPruebasUnitarias {
    
    class Medias {

        /**
         * Calcula y regresa la media artimética
         */
        public static double mediaAritmetica(params int[] vals) 
        {
        double sum=0;
        
        sum=sumaArray(vals)/vals.Length;
        
        return sum;
        }
        
        /**
         * Calcula y regresa la raíz enésima = x^(1/n)
         */
        private static double raizEnesima(double x, int n) 
        {
            double raiz=0;
            double y=n;
            raiz= Math.Pow(x,1/y);
            
            return raiz;
        }
        
        /**
         *  Usa raizEnesima para calcular y regresar la media geométrica
         */
        public double mediaGeometrica(params int[] vals) 
        {
            double media;
            media=multArray();
            media=raizEnesima(media,vals.Length);
            return media;
        }

        /**
         * Este método no está implementado.
         */
        public static double mediaArmonica(params int[] vals) 
        {
			double media=0;
			
			return media;
        }

        public static double sumaArray(params int[] vals)
        {
            double sum=0;

            for (int i = 0; i < vals.Length; i++)
            {
                sum+=vals[i];
            }

            return sum;
        }

        public static double multArray(params int[] vals)
        {
            double mult=1;

            for (int i = 0; i < vals.Length ; i++)
            {
                mult*=vals[i];
            }

            return mult;
        }
    }
}