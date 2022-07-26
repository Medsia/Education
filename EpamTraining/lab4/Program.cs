using System;

namespace lab4
{

    class Polynomial
    {    
        public double x;
        public double y;
        public double x1;
        public double y1;

        public Polynomial()
        {
        }
        
        public static double z = 2;
        public void Multiplication()
        {
            double SumY = Math.Pow(x, 2) * x1;
            double SumX = Math.Pow(x, 2) * Math.Pow(x1, 2);
            double SumZ = Math.Pow(x, 2) * Math.Pow(x1, 2);
            double SumB = Math.Pow(x, 2) * Math.Pow(x1, 2);
            Console.WriteLine("(a^2){0} + ab{1} + ac{2} + (b^2){3} + bc{4} c^2", SumX, SumY + x * Math.Pow(x1, 2), Math.Pow(x, 2) + Math.Pow(x1, 2), x*x1, x+x1);
        }
        public void Sum()
        {
            double SumY = x + x1;
            double SumX = Math.Pow(x, 2) + Math.Pow(x1, 2);
            Console.WriteLine("a{0} + b{1} + 2c", SumX, SumY);
        }
        public void Sub()
        {
            double SumY = x - x1;
            double SumX = Math.Pow(x, 2) - Math.Pow(x1, 2);
            Console.WriteLine("a{0} + b{1}", SumX, SumY);
        }
        public void Add()
        {
            Console.WriteLine("Введите значение 1 аргумента");
            x = Double.Parse(Console.ReadLine());
            Polynomial poly = new Polynomial();
            poly.x = x;
            poly.y = Math.Pow(poly.x, 2);
            
            Console.WriteLine("a{0} + b{1} + c", poly.y, poly.x);
            Console.WriteLine("Введите значение 2 аргумента");
            x1 = Double.Parse(Console.ReadLine());
            poly.x1 = x1;
            poly.y1 = Math.Pow(poly.x1, 2);     

            Console.WriteLine("a{0} + b{1} + c", poly.y1, poly.x1);
        }

        public void Show()
        {
            Console.WriteLine("a{0} + b{1} + c", Math.Pow(x, 2), x);
            Console.WriteLine();
            Console.WriteLine("a{0} + b{1} + c", Math.Pow(x1, 2), x1);
        }
    }

    class Program {
        static void Main(string[] args)
        {
            Polynomial poly = new Polynomial();
            Start:
            Console.WriteLine("\nВыберите операцию:\n1.Создать\n2.Сложить\n3.Вычесть\n4.Умножить\n5.Вывод описания\n6.Выход\n");
            int c = Int32.Parse(Console.ReadLine());          
            switch (c)
            {
                case 1:

                    poly.Add();
                    
                    goto Start;
                case 2:
                    poly.Sum();
                   
                    goto Start;
                case 3:
                    poly.Sub();
                    goto Start;
                case 4:
                    poly.Multiplication();
                    goto Start;
                case 5:
                    poly.Show();

                    goto Start;
                case 6:

                    break;

                default:

                    Console.WriteLine("Неверное значение");
                    goto Start;
            }
        }
    }
}
