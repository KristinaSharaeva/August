using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August
{
    internal class Task25
    {
        public static void Test()
        {
            Console.Write("Write a number");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Write a number");
            int b = int.Parse(Console.ReadLine());


            int stepen(int a, int b)

                {
                int sum = 1;
                for (int i = 0; i < b; i++)
                {
                    sum = sum * a;
                }
                return sum;
            }
             Console.WriteLine(stepen(a,b));
          
        }
    }
}
