using System;

namespace lab8
{
    public class Program
    {      
        static void Main()
        {
            try { 
            Console.WriteLine("Введите размер матрицы");
            Console.WriteLine("Количество строк :");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Количество столбцов :");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите размер второй матрицы");
            Console.WriteLine("Количество строк :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Количество столбцов :");
            int b = Convert.ToInt32(Console.ReadLine());

            double[,] matrix1 = new double[m, n];
            double[,] matrix2 = new double[a, b];
            
            Console.WriteLine("Заполнить случайными числами?\n1.Да\n2.Нет");
            int r = Int32.Parse(Console.ReadLine());
            if(r == 1)
            {
                Random random = new Random();
                FillMatrixRandom(matrix1, random);
                FillMatrixRandom(matrix2, random);
            }
            else
            {
                Console.WriteLine("Матрица 1:\t");
                WriteMatrix(matrix1);
                Console.WriteLine("Матрица 2:\t");
                WriteMatrix(matrix2);
            }
            

            Console.WriteLine("Матрица 1:\t");
            MatrixOutput(matrix1);
            Console.WriteLine("Матрица 2:\t");
            MatrixOutput(matrix2);

        Start:
            Console.WriteLine("\nВыберите операцию:\n1.Сложение\n2.Вычитание\n3.Умножение\n4.Выход");
            int c = Int32.Parse(Console.ReadLine());
            switch (c)
            {
                case 1:
                    double[,] matrix3 = MatrixSumm(matrix1, matrix2);
                    MatrixOutput(matrix3);
                    goto Start;
                case 2:
                    double[,] matrix4 = MatrixDiff(matrix1, matrix2);
                    MatrixOutput(matrix4);
                    goto Start;
                case 3:
                    Console.WriteLine("\nВыберите операцию:\n1.Умножение 1 матрицы на 2 матрицу\n2.Умножение 2 матрицы на 1 матрицу");
                    Console.WriteLine("3.Умножение 1 матрицы на число\n4.Умножение 2 матрицы на число\t");
                    int s = Int32.Parse(Console.ReadLine());
                    switch (s)
                    {
                        case 1:
                            double[,] matrix5 = MxMMult(matrix1, matrix2);
                            MatrixOutput(matrix5);
                            goto Start;
                        case 2:
                            double[,] matrix6 = MxMMult(matrix2, matrix1);
                            MatrixOutput(matrix6);
                            goto Start;
                        case 3:
                            Console.WriteLine("Введите число:\t");
                            double sc = Convert.ToDouble(Console.ReadLine());
                            double[,] matrix7 = MatrixMult(matrix1, sc);
                            MatrixOutput(matrix7);
                            goto Start;
                        case 4:
                            Console.WriteLine("Введите число:\t");
                            double scc = Convert.ToDouble(Console.ReadLine());
                            double[,] matrix8 = MatrixMult(matrix2, scc);
                            MatrixOutput(matrix8);
                            goto Start;
                        default:
                            Console.WriteLine("Неверное значение");
                            goto Start;
                    }
                case 4:
                    break;

                default:
                    Console.WriteLine("Неверное значение");
                    goto Start;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Message:  {0}", e.Message);
                Console.WriteLine("Please restart the program");
            }

        }
        public static void FillMatrixRandom(double[,] matrix, Random random)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(-10, 10);
                }
            }
        }

        static void MatrixOutput(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        // Summ
        public static double[,] MatrixSumm(double[,] matrix1, double[,] matrix2)
        {
            double[,] matrix3 = new double[matrix1.GetLength(0), matrix1.GetLength(1)];
            if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
            {
                Console.WriteLine("Размеры матриц не совпадают, операция невозможна");
                return matrix3;
            }

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix3[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return matrix3;
        }

        // Diff
        public static double[,] MatrixDiff(double[,] matrix1, double[,] matrix2)
        {
            double[,] matrix3 = new double[matrix1.GetLength(0), matrix1.GetLength(1)];

            if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
            {
                Console.WriteLine("Размеры матриц не совпадают, операция невозможна");
                return matrix3;
            }

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix3[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            return matrix3;
        }

        // Mult num
        public static double[,] MatrixMult(double[,] matrix, double sc)
        {
            double[,] matrix3 = new double[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix3[i, j] = matrix[i, j] * sc;
                }
            }
            return matrix3;
        }

        // Mult mx
        public static double[,] MxMMult(double[,] matrix1, double[,] matrix2)
        {
            
            double[,] matrix3 = new double[matrix1.GetLength(0), matrix2.GetLength(1)];

            if (matrix1.GetLength(1) != matrix2.GetLength(0))
            {
                Console.WriteLine("Количество столбцов №1 матрицы не совпадает с количеством строк №2 матрицы!");
                return matrix3;
            }

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    double result = 0;
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {
                        result += matrix1[i, k] * matrix2[k, j];
                    }

                    matrix3[i, j] = result;
                }
            }
            return matrix3;
        }
        static void WriteMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine("Введите элемент матрицы {0}:{1}", i + 1, j + 1);
                    matrix[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
        }
    }
}
