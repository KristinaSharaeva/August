using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August
{
    internal class Task54
    {
        public static void Test()
        {
            int m = 4;
            int n = 8;
            int temp = 0;
            int[,] myArr = new int[m, n];
            Random ran = new Random();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    myArr[i, j] = ran.Next(1, 10);
                    Console.Write("{0}\t", myArr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("original array is on top");


            for (int i2 = 0; i2 < m; i2++)
            {

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < (n - 1); j++)
                    {
                        if (myArr[i2, j] >= myArr[i2, j + 1])
                        {
                            temp = myArr[i2, j];

                            myArr[i2, j] = myArr[i2, j + 1];
                            myArr[i2, j + 1] = temp;
                        }



                    }

                }
            }

            for (int i2 = 0; i2 < m; i2++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(myArr[i2, j]);


                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.Write("finish");
        }
    }
}
