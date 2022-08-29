using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August
{
    internal class Task27
    {
        public static void Test()
        {
          Console.Write("Write a number");
          int n = int.Parse(Console.ReadLine());
            int sum = 0;
          
                while (n != 0)
                {
                sum = sum + n % 10;
                n = n / 10;
                  }
                      
            
            Console.WriteLine(sum);

        }

        }
}
