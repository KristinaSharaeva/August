using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August
{
    internal class Task47
    {
        public static void Test()
        {
            int m = 3;
            int n= 4;
          
            int[,] array = new int[m, n];


            Random rnd = new Random(); ;
            for (int i = 0; i < m; i++)

            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = rnd.Next();
                    Console.Write(array[i, j] + "  ") ;
                    
                }
                Console.WriteLine("  "); 
            }

            

        }

    }
}
