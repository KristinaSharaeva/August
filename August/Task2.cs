using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August
{
    internal class Task2
    {
        public static void Test()
        {
            Console.Write("Write a number");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Write a number");
            int b = int.Parse(Console.ReadLine());

            if (a >= b)
                Console.WriteLine(a); 
            else Console.WriteLine(b);
        }
    }
    
}
