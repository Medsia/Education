using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите точность");
            double ep = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите начало отрезка");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите конец отрезка");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите шаг");
            double h = Convert.ToDouble(Console.ReadLine());
            double x = a, s, y;
            const int MaxIter = 500;
            bool done = true;
            int i;
            Console.WriteLine(" _______________________");
            Console.WriteLine("|x|Сумма ряда|n|Зн. функции|");
            Console.WriteLine(" ________________________");
            while (x <= b)
            {
                s = 1; y = s;
                done = true;
                for ( i = 0; Math.Abs((Math.PI / 2 - Math.Atan(s))) > ep; i++)
                {
                    s *= (-(x * x) * (2 * i + 1)) / (2 * i + 3);
                    y += ((Math.PI / 2) + s);
                    if (i > MaxIter) { done = false; break; }
                }
                if (done == true) Console.WriteLine("|{0,5}|{1,18}|{2,5}|{3,18}| ",x,y,i, s);

                else Console.WriteLine("|{0,5}|Ряд расходится| ", x);
                x = x + h;
            }
        }
    }
}
