using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August
{
    internal class Task8
    {
        public static void Test()
        {
            Console.Write("Write a number");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i < N+1; i++)
            {
                if (i % 2 == 0)
                
                    Console.WriteLine(i);

                       
            }
        }
    }
}
