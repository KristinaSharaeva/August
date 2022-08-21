using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August
{
    internal class Task15
    {
        public static void Test()
        {
            Console.Write("Write a number of the week day");
            int N = int.Parse(Console.ReadLine());
            if (N < 6)
                Console.WriteLine("No");
            else Console.WriteLine("Yes");
        }
    }
}
