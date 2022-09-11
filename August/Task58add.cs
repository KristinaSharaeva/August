using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August
{
    internal class Task58add
    {
        public static void Test()
        {
            int m = 3;


            int[,] myArrA = new int[m, m];
            Random ran = new Random();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    myArrA[i, j] = ran.Next(1, 10);
                    Console.Write("{0}\t", myArrA[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("original array A is on top");

            int[,] myArrB = new int[m, m];
           

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    myArrB[i, j] = ran.Next(1, 10);
                    Console.Write("{0}\t", myArrB[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("original array B is on top");

            int[,] myArrC = new int[m, m];

            int sum = 0;


            for (int j = 0; j < m; j++)
            {

                for (int i = 0; i < m; i++)
                {
                    for (int x = 0; x < m; x++)
                    {


                        sum = sum + (myArrA[j, x] * myArrB[x, i]);

                        myArrC[j, i] = sum;

                    }
                    sum = 0;
                }
            }

            for (int i2 = 0; i2 < m; i2++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0}\t", myArrC[i2, j]);


                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.Write("finish");

        }
    }
}
