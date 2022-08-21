using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August
{
    internal class Task23
    {
        public static void Test()
        {
            Console.Write("Write a number");
            int N = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < (N +1); i++)
            {
                int result = i * i * i;
                Console.WriteLine(result);
            }

        }
    }
}
