using System;
using System.Collections.Generic;
using System.Text;
namespace Lab3_1
{
    class Program
    {
        static void Main()
        {
            double R = 3, f;
            try
            {
                Console.WriteLine("Введите -7<=x<=11");
           double x = Convert.ToDouble(Console.ReadLine());
                if (x >= -7 && x <= -3)
                    f = 3;
                else if (x > -3 && x <= 3) f = -Math.Sqrt(Math.Pow(R, 2) -Math.Pow(x , 2)) + 3;
                else if (x > 3 && x <= 6) f = -2 * x + 9;
                else f = x - 9 ;
                Console.WriteLine("Для x=" + x);
                Console.WriteLine("f={0}", f);
            }
            catch (FormatException)
            { Console.WriteLine("Неверный ввод"); }
        }
    }
}
