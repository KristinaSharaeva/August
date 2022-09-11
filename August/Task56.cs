using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August
{
    internal class Task56
    {
        public static void Test()
        {
            int m = 7;
            int n = 10;
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

            
          
            int[] sumFin = new int[m];

            for (int i = 0; i < m; i++)
            {

                for (int j = 0; j < n; j++)
                {

                    sumFin[i] = sumFin[i] + myArr[i, j];

                }
                             
               
            }
            int imin = sumFin[0];
            int result = 0;
            for (int i = 1; i < m; i++)
            {
                
                if (imin > sumFin[i])
                {
                    imin = sumFin[i];
                    result = i;
                }
                
            }
            Console.WriteLine("{0}\t", result); 

            Console.Write("finish");
        }
    }
}
