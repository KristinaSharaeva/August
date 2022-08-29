using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August
{
    internal class Task29

    {
        public static void Test()
        { 
        int[] result = FillArray (8, 6, 10);
        PrintArr(result);

        int[] FillArray(int n, int min, int max)
        {
            int[]array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(min, max);
            }
            return array;
        }

        void PrintArr(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i] + "   ");
                }
            }
        }
    }
}
