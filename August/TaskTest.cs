using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August
{
    internal class TaskTest
    {
        public static void Test()
        {
           
            int[] Arr = { 8, 3, 5, 2, -3 }; 
            int Arrmin = Arr[0];
            
            for (int i = 1; i < Arr.Length; i++)
            {
                if (Arrmin > Arr[i])
                {
                    Arrmin = Arr[i];
                }
            }
            Console.WriteLine(Arrmin);
        }
    }
}
