using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Texto {

        /**
         * Calcula y regresa la media artimética
         */
        public static int[] procText(string path) 
        {
            int[] array1 = new int[] { };
            try 
            {
                if (File.Exists(path)) 
                {
                File.Delete(path);
                }

                using (StreamReader st = new StreamReader(path)) 
                {
                    string s="";
                    string[] array2 = new string[] {};
                    while (st.Peek() >= 0) 
                    {
                        s=st.ReadLine();
                    }
                    array2=s.Split(':');
                }
            } 
            catch (Exception e) 
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            return array1;
        }
}
