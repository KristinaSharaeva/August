using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August
{
    internal class Task38
    {
        public static void Test()
        {
            double[] array1 = new double[] { 3.5, 7.1, 22.9, 2.3, 78.5 };



            double temp;
            for (int i = 0; i < array1.Length - 1; i++)
            {
                for (int j = i + 1; j < array1.Length; j++)
                {
                    if (array1[i] > array1[j])
                    {
                        temp = array1 [i];
                        array1[i] = array1[j];
                        array1[j] = temp;
                    }
                }

                
            }
            double last = array1.Last();

            double first = array1.First();
           
            double result = last - first;

            Console.WriteLine(result);
        }        
    }
}
