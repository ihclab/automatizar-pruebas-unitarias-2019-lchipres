using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.StreamReader;

class Texto {

        /**
         * Calcula y regresa la media artimética
         */
        public static int[] procText(string path) 
        {
            int[] arr= new Array[100];
            StreamReader sr = new StreamReader(path);
            try 
            {
                if (File.Exists(path)) 
                {
                File.Delete(path);
                }

                using (StreamReader sr = new StreamReader(path)) 
                {
                    while (sr.Peek() >= 0) 
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }
            } 
            catch (Exception e) 
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            return arr;
        }
}
