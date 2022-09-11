using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August
{
    internal class Task62
    {
        public static void Test()
        {
            int m = 11;
            int[,] myArr = new int[m, m];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    myArr[i, j] = 0;
                   

                }
              
            }


            Console.WriteLine("-------------------------------");

            int direction = 0;
             
            
            int i2 = 0;
            int v = 1;
            int j2 = 0;
            int line = 0;
            int column = m-1;
            
            for (int k = 0; k < m/2+1; k++)
            {
                Console.WriteLine(k);


                if (direction%4 == 0)
                    
                {
                    
                    while ( j2 < m)
                    
                    {
                        if (myArr[line,j2] == 0)
                        {
                            myArr[line, j2] = v;
                            v++;
                          
                        }
                       
                        j2++;
                       
                    }
                  direction++; 

                }
               
                if (direction % 4 == 1)
                {
                   
                    while ( i2 < m)
                       
                    {
                        if (myArr[i2, column] == 0)
                        {
                            myArr[i2, column] = v;
                            v++;

                        }
                        i2++;
                    }
                  direction++; 

                }
                if (direction % 4 == 2)
                {
                    j2--;
                    while (j2 >=0)

                    {
                        
                        if (myArr[column, j2] == 0)
                        {
                            myArr[column, j2] = v;
                            v++;

                        }

                        j2--;
                    }
                    direction++;
                }
                if (direction % 4 == 3)
                {
                   
                    i2--;
                    while (i2 >=0)

                    {
                       
                        if (myArr[i2, line] == 0)
                        {
                            
                            myArr[i2, line] = v;
                            v++;

                        }
                        i2--;
                    }
                   if (line<m-1) line++;
                  direction++;
                    j2++;
                    i2++;
                   if (column>0) column--;  

                }

            }

            Console.WriteLine("-------------------------------");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0}\t", myArr[i, j]);


                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.Write("finish");

        }
    }
}
