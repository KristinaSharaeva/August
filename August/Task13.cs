using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August
{
    internal class Task13
    {
        public static void Test()
        {
            Console.Write("Write a number");
            int N = int.Parse(Console.ReadLine());

            if (N < 100)
                Console.WriteLine("There is no third number");

            if
                (N < 1000 && N > 99)
            {
                N = N % 10;
                Console.WriteLine(N);
            }

            if (N > 999)
            {
                do
                {
                    N = N / 10;
                }

                while (N > 999);

                N = N % 10;

                Console.WriteLine(N);
            }
            }

        }

    }
