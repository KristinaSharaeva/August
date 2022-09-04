using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August
{
    internal class Task50
    {
        public static void Test()
        {
            int m = 4;
            int n = 3;
            Console.Write("Write a number of a line");
            int l = int.Parse(Console.ReadLine());

            Console.Write("Write a number of a row");
            int r = int.Parse(Console.ReadLine());
            
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
            if (l<m&& r<n)
                Console.WriteLine(myArr[l, r]);
            else Console.WriteLine("there is no such number");
            
        }

        }
    }
