using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August
{
    internal class Task43
    {
        public static void Test()
        {
            Console.Write("Write a number b1   ");
            double b1 = int.Parse(Console.ReadLine());

            Console.Write("Write a number k1   ");
            double k1 = int.Parse(Console.ReadLine());

            Console.Write("Write a number b2   ");
            double b2 = int.Parse(Console.ReadLine());

            Console.Write("Write a number k2   ");
            double k2 = int.Parse(Console.ReadLine());
            
            double x = 1;
            double y = 1;

            x = (b2 - b1) / (k1 - k2);
            y = k1*x + b1;
            string str1 = x.ToString();
            string str2 = y.ToString();

            Console.WriteLine(str1); Console.WriteLine(str2);
        }
        }
}
