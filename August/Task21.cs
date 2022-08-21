using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August
{
    internal class Task21
    {
        public static void Test()
        {
            Console.Write("Введите значение X1   ");
            int X1 = int.Parse(Console.ReadLine());
            Console.Write("Введите значение Y1   ");
            int Y1 = int.Parse(Console.ReadLine());
            Console.Write("Введите значение Z1   ");
            int Z1 = int.Parse(Console.ReadLine());

            Console.Write("Введите значение X2   ");
            int X2 = int.Parse(Console.ReadLine());
            Console.Write("Введите значение Y2   ");
            int Y2 = int.Parse(Console.ReadLine());
            Console.Write("Введите значение Z2   ");
            int Z2 = int.Parse(Console.ReadLine());

            double d = Math.Sqrt((Math.Pow((X2 - X1), 2)) + (Math.Pow((Y2 - Y1), 2)) + (Math.Pow((Z2 - Z1), 2)));
            Console.WriteLine (d);

        }
    }
}
