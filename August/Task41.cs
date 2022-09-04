using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August
{
    internal class Task41
    {
        public static void Test()
        {
            Console.Write("Write how many numbers you'd like to put in a programm  ");
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("put the number  ");
                a = int.Parse(Console.ReadLine());

                if (a > 0)
                {
                    sum++;

                }
               
            }
            Console.WriteLine(sum);
        }
    }
}

