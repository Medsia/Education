using System;


namespace Multimember
{
    class Task2
    {
        public static int n;
        public static int n2;
        public static double y;
        internal static void Multimember()
        {
           
            Console.WriteLine("Введите степень многочлена:");  
            int Degree = Convert.ToInt32(Console.ReadLine());
            n = Degree + 1;//Длина многочлена  
            double Val = 0;
            double[] Matrix;
            Matrix = new double[n];
            Console.WriteLine("Введите матрицу коэффициентов многочлена:");
            for (int i = 0; i <= Degree; i++)
            {
                Matrix[i] = Convert.ToInt32(Console.ReadLine());

            }
            MultiMember A = new MultiMember(Matrix, Degree);

            Console.WriteLine("Введите значение x:");
            y = Convert.ToDouble(Console.ReadLine());
            double x = y;
            //Ввод второго многочлена
            Console.WriteLine("Введите степень второго многочлена:");
            //int Degree2 = 2;
            int Degree2 = Convert.ToInt32(Console.ReadLine());
            n2 = Degree2 + 1;//Длина многочлена  
            double[] Matrix2;
            Matrix2 = new double[n2];
            Console.WriteLine("Введите матрицу коэффициентов второго многочлена:");
            for (int i = 0; i <= Degree2; i++)
            {
                Matrix2[i] = Convert.ToInt32(Console.ReadLine());
            }
              
            MultiMember B = new MultiMember(Matrix2, Degree2);

            Console.Write("A=");
            Console.WriteLine(A.Vivod(A));
            A.calculate(Matrix, Val, x, Degree);
            Console.Write("B=");
            Console.WriteLine(B.Vivod(B));
            B.calculate(Matrix2, Val, x, Degree2);
        Start:
            Console.WriteLine("\nВыберите операцию:\n1.Сложение\n2.Вычитание\n3.Умножение\n4.Выход\n");
            int c = Int32.Parse(Console.ReadLine());
            switch (c)
            {
                case 1:

                    MultiMember C = A + B;
                    Console.Write("A+B=");
                    if(C != null)
                    Console.WriteLine(C.Vivod(C) + "\n");
                    break;
                case 2:
                    MultiMember D = A - B;
                    Console.Write("A-B=");
                    if (D != null)
                        Console.WriteLine(D.Vivod(D) + "\n");
                    break;
                case 3:
                    MultiMember E = A * B;
                    Console.Write("A*B=");
                    if (E != null)
                        Console.WriteLine(E.vivod(E) + "\n");

                    break;               
                case 4:

                    break;

                default:

                    Console.WriteLine("Неверное значение");
                    goto Start;
            }

        }
    }
    public class MultiMember
    {

        public readonly double[] polynomial;
        public MultiMember(params double[] args)
        {
            polynomial = args ?? throw new ArgumentNullException();
        }
        public double[] Matrix;
        int Degree;
        
        public MultiMember(double[] matrix, int degree)
        {
            Matrix = matrix;
            Degree = degree;
        }


        // Перегрузка оператора +
        public static MultiMember operator +(MultiMember A, MultiMember B)
        {
            
            int D1 = A.Degree;
            double[] M1 = new double[D1 + 1];
            MultiMember C = new MultiMember(M1, D1);
            int overide = 0;
            if (A.Matrix.Length >= B.Matrix.Length)
            {
                overide = A.Matrix.Length - B.Matrix.Length;
                Array.Resize(ref B.Matrix, A.Matrix.Length);
                Array.Resize(ref C.Matrix, A.Matrix.Length);
                A.Degree = A.Matrix.Length - 1;               
                C.Degree = A.Degree;
                for (int fillempty = overide; 1 <= fillempty;)
                {
                    C.Matrix[fillempty - 1] = A.Matrix[fillempty - 1];
                    fillempty--;
                }
                for (int i = 0 + overide; i < A.Degree + 1; i++)
                {
                    C.Matrix[i] = A.Matrix[i] + B.Matrix[i - overide];
                }
            }
            else
            {
                overide = B.Matrix.Length - A.Matrix.Length;
                Array.Resize(ref A.Matrix, B.Matrix.Length);
                Array.Resize(ref C.Matrix, B.Matrix.Length);
                A.Degree = B.Matrix.Length - 1;
                C.Degree = A.Degree;
                for (int fillempty = overide; 1 <= fillempty;)
                {
                    C.Matrix[fillempty - 1] = B.Matrix[fillempty - 1];
                    fillempty--;
                }
                for (int i = 0 + overide; i < A.Degree + 1; i++)
                {
                    C.Matrix[i] = A.Matrix[i - overide] + B.Matrix[i];
                }
            }           
            return C;
        }
        // Перегрузка оператора -
        public static MultiMember operator -(MultiMember A, MultiMember B)
        {
            int D1 = A.Degree;
            double[] M1 = new double[D1 + 1];
            MultiMember C = new MultiMember(M1, D1);
            int overide = 0;
            if (A.Matrix.Length >= B.Matrix.Length)
            {
                overide = A.Matrix.Length - B.Matrix.Length;
                Array.Resize(ref B.Matrix, A.Matrix.Length);
                Array.Resize(ref C.Matrix, A.Matrix.Length);
                A.Degree = A.Matrix.Length - 1;
                C.Degree = A.Degree;
                for (int fillempty = overide; 1 <= fillempty;)
                {
                    C.Matrix[fillempty - 1] = A.Matrix[fillempty - 1];
                    fillempty--;
                }
                for (int i = 0 + overide; i < A.Degree + 1; i++)
                {
                    C.Matrix[i] = A.Matrix[i] - B.Matrix[i - overide];
                }
            }
            else
            {
                overide = B.Matrix.Length - A.Matrix.Length;
                Array.Resize(ref A.Matrix, B.Matrix.Length);
                Array.Resize(ref C.Matrix, B.Matrix.Length);
                A.Degree = B.Matrix.Length - 1;
                C.Degree = A.Degree;
                for (int fillempty = overide; 1 <= fillempty;)
                {
                    C.Matrix[fillempty - 1] = B.Matrix[fillempty - 1];
                    fillempty--;
                }
                for (int i = 0 + overide; i < A.Degree + 1; i++)
                {
                    C.Matrix[i] = A.Matrix[i - overide] - B.Matrix[i];
                }

            }                
            return C;
        }
        // Перегрузка оператора *
        public static MultiMember operator *(MultiMember A, MultiMember B)
        {
            
            var multResult = new double[A.Matrix.Length + B.Matrix.Length - 1];

            for (int i = 0; i < A.Matrix.Length; i++)
            {
                for (int j = 0; j < B.Matrix.Length; j++)
                {
                    multResult[i+j] += A.Matrix[i] * B.Matrix[j];
                }
            }
            return new MultiMember(multResult);
           
        }

        public int Vivod(MultiMember A)
        {
            
            for (int i = 0; i < A.Matrix.Length; i++)
            {
                Console.Write(A.Matrix[i] + "X" + "^" + (Degree - i) + "+");
            }
            
            return 0;
        }
        public int vivod(MultiMember A)
        {

            for (int i = 0; i < polynomial.Length; i++)
            {
                Console.Write(polynomial[i] + "X" + "^" + (polynomial.Length - i - 1) + "+");
            }
            return 0;
        }
        //вычисление значения многочлена для заданного аргумента
        public double calculate(double[] matrix, double value, double x, int Degree)
        {
            
            for (int i = Degree; i > 0; i--)
            {
                double z = x;
                for (int j = i; j < Degree; j++) z *= x;
                value += matrix[i - 1] * z;//умножаем его на коэффицент многочлена и прибавляем к основной сумме
            }
            value += matrix[Degree];
            Console.WriteLine($"значения многочлена для x={x}: " + value + "\n");
            return value;//прибавляем к основной сумме последний элемент и возвращаем значение
        }
        public double this[int i]
        {
            get { return Matrix[i]; }
            set { Matrix[i] = value; }
        }


    }
     
}
