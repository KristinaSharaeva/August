using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August
{
    internal class Task60
    {
        public static void Test()
        {
            int[,,] myArr = new int[2,2,2] { { { 66,25},{34,41 } },{ {27,90 },{26,55 } } };
            for (int i = 0; i < 2; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Console.Write(myArr[i, i2, j]);
                        Console.Write("(");
                        Console.Write(i);
                        Console.Write(",");
                        Console.Write(i2);
                        Console.Write(",");
                        Console.Write(j);
                        Console.Write(")");
                       
                    }
                    Console.WriteLine();
                }
            }



        }
        
        

    }
}
