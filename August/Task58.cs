using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August
{
    internal class Task58
    {
        public static void Test()
        {
            int[,] myArr = new int[2,2] { { 2,4 }, { 3,2 } };
            int[,] myArr2 = new int[2, 2] { { 3,4 }, { 3,3 } };
            int[,] myArr3 = new int[2, 2];
           myArr3[0,0] = (myArr[0, 0] * myArr2[0,0] + (myArr[0,1]* myArr2[1,0]));
            myArr3[0,1] = (myArr[0, 0] * myArr2[0, 1] + (myArr[0, 1] * myArr2[1, 1]));
            myArr3[1, 0] = (myArr[1, 0] * myArr2[0, 0] + (myArr[1, 1] * myArr2[1, 0]));
            myArr3[1, 1] = (myArr[1, 0] * myArr2[0, 1] + (myArr[1, 1] * myArr2[1, 1]));

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("{0}\t", myArr3[i, j]);


                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.Write("finish");
        }

    }
}
