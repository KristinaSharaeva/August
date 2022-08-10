 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August
{
    internal class Task4
    { public static void Test()
        {
            Console.Write("Write a number");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Write a number");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Write a number");
            int c = int.Parse(Console.ReadLine());

            if ((a > b) & (a > c))
                Console.Write(a);

            if ((b > c) & (b > a))
                Console.Write(b);

            if ((c > b) & (c > a))
                Console.Write(c);

            if ((a == b) ||  (b == c) || (a==c));
            Console.Write ("Please try again and make sure all three numbers are different");
        }
    }
}
