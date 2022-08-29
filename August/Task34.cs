using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August
{
    internal class Task34
    {
        public static void Test()
        {
            int[] result = FillArray(4 , 100, 999);
            PrintArr(result);

            int[] FillArray(int n, int min, int max)
            {
                int[] array = new int[n];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = new Random().Next(min, max);
                }
                return array;
            }

            void PrintArr(int[] array)
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0) 
                    {
                       sum = sum + 1;
                    }
                   
                    Console.WriteLine(array[i] + "   ") ;
                   
                }
                Console.WriteLine(sum);

            }
        }
    }
}
