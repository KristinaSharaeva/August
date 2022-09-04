using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August
{
    internal class Task52
    {
        public static void Test()
        {
            int m = 4;
            int n = 3;
            float sum = 0;
            int[,] myArr = new int[m, n];
            Random ran = new Random();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    myArr[i, j] = ran.Next(1, 60);
                    Console.Write("{0}\t", myArr[i, j]);
                }
                Console.WriteLine();
            }
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < m; i++)
                {
                    sum = sum + myArr[i, j];

                }
                Console.WriteLine(sum / m);

                sum = 0;
            }

        }

    }
}
    
