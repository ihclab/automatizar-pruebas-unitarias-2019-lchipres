using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
        public static void mediaArmonica(params int[] vals) 
        {
            try{

            }
            catch(Exception e){
                Console.WriteLine("Message:\n  Este metodo aun no esta implementado\n", e.Message);
                throw e;
            }
        }
        

        private static double sumaArray(params int[] vals)
        {
            double sum=0;

            for (int i = 0; i < vals.Length; i++)
            {
                sum+=vals[i];
            }

            return sum;
        }//Suma de valores en array

        private static double multArray(params int[] vals)
        {
            double mult=1;

            for (int i = 0; i < vals.Length ; i++)
            {
                mult*=vals[i];
            }

            return mult;
        }//Multiplicacion de valores en un array
    }
}