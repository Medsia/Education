using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1 or 2:");
            int c = Int32.Parse(Console.ReadLine());
            switch(c)
            {
            //Task 1(nth root calculation)
            case 1:
                // Math.Pow Method
                Console.WriteLine("The n root of x");
                Console.WriteLine("x: ");
                double x = Double.Parse(Console.ReadLine());
                Console.WriteLine("n: ");
                double n = Double.Parse(Console.ReadLine());
                Console.WriteLine("EPS: ");
                double eps = Double.Parse(Console.ReadLine());

                double a = Math.Pow(x, 1 / n);                 

                Console.WriteLine("The {0}th root of {1} is: {2}(Math.Pow Method) and {3}(Newton's Method)", n, x, a, SqrtN(n, x, eps));

                // Newton's Method
                static double SqrtN(double n, double A, double eps)
                {
                    var x0 = A / n;
                    var x1 = (1 / n) * ((n - 1) * x0 + A / Math.Pow(x0, (int)n - 1));

                    while (Math.Abs(x1 - x0) > eps)
                    {
                        x0 = x1;
                        x1 = (1 / n) * ((n - 1) * x0 + A / Math.Pow(x0, (int)n - 1));
                    }

                    return x1;
                }
                break;
                // Task 2(binary conversion)
                case 2:
                    Console.WriteLine("Enter the number:");
                    uint num = uint.Parse(Console.ReadLine());
                    string s_bit = Convert.ToString(num, 2);
                    Console.WriteLine("Result:" + s_bit);

                    break;
            }
        }
    }
    }

