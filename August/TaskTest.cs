﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August
{
    internal class TaskTest
    {
        public static void Test()
        {
            int m = 4;
            int n = 3;
            int sum = 0;
            int[,] myArr = new int[m, n];
            Random ran = new Random();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    myArr[i, j] = ran.Next(1, 6);
                    Console.Write("{0}\t", myArr[i, j]);
                }
                Console.WriteLine();
            }

            
            //Console.WriteLine(myArr[0, 0]);
            //Console.WriteLine(myArr[1, 0]);
            //Console.WriteLine(myArr[2, 0]);
            //Console.WriteLine(myArr[3, 0]);
            
            for (int i = 0; i < m; i++)
            {
                Console.Write(myArr[i,0]);
            }
        }

    }
}
