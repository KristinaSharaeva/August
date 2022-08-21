using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August
{
    internal class Task19
    {
        public static void Test()
        {
            Console.Write("Write a number");
            int N = int.Parse(Console.ReadLine());
            int N5 = N % 10;
            int N4 = N % 100/10;
            int N3 = N % 1000 / 100;
            int N2 = N % 10000 / 1000;
            int N1 = N % 100000 / 10000;

            if (N1 == N5 && N2 == N4)
                Console.WriteLine("yes");
            else Console.WriteLine("no");

        }
    }
}
