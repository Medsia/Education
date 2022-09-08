using System;


namespace Vector
{
    class Task1
    {
        static Vector vector1;
        static Vector vector2;
        internal static void vector()
        {
            Console.WriteLine("Ввведите 3 координаты вашего 1 вектора");
            Console.WriteLine("Введите значение x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y:");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение z:");
            double z = Convert.ToDouble(Console.ReadLine());
            vector1 = new Vector(x, y, z);
            Console.WriteLine("Введите 3 координаты вашего 2 вектора");
            Console.WriteLine("Введите значение x:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y:");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение z:");
            double z1 = Convert.ToDouble(Console.ReadLine());
            vector2 = new Vector(x1, y1, z1);
            
        //Ввод второго многочлена
        Start:
            Console.WriteLine("\nВыберите операцию:\n1.Сложение\n2.Вычитание\n3.Умножение\n4.Длинна\n5.Выход");
            int c = Int32.Parse(Console.ReadLine());
            switch (c)
            {
                case 1:
                    //Vector vector3 = new Vector();
                    Vector A = vector1 + vector2;
                    Console.WriteLine($"\nЗначение нового вектора: x3={A.x} y3={A.y} z3={A.z}\n");
                    goto Start;
                case 2:
                    Vector B = vector1 - vector2;
                    Console.WriteLine($"\nЗначение нового вектора: x3={B.x} y3={B.y} z3={B.z}\n");
                    goto Start;
                case 3:
                    Console.WriteLine("\nВыберите операцию:\n1.Умножение 1 вектора на число\n2.Умножение 2 вектора на число\n");
                    int d = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("\nВведите число:\n");
                    double sc = Double.Parse(Console.ReadLine());
                    if (d == 1)
                    {
                        Vector C = vector1 * sc;
                        Console.WriteLine($"\nЗначение нового вектора: x3={C.x} y3={C.y} z3={C.z}\n");
                    }
                    else
                    {
                        Vector C = vector2 * sc;
                        Console.WriteLine($"\nЗначение нового вектора: x3={C.x} y3={C.y} z3={C.z}\n");
                    }
                    goto Start;
                case 4:

                    Vector.lenght(vector1, vector2);
                    goto Start;
                case 5:

                    break;
                default:

                    Console.WriteLine("Неверное значение");
                    goto Start;
            }

        }
    }
    public class Vector
    {
        public double x;
        public double y;
        public double z;
        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        // Перегрузка оператора +
        public static Vector operator +(Vector vector1, Vector vector2)
        {
            double x3 = vector1.x + vector2.x;
            double y3 = vector1.y + vector2.y;
            double z3 = vector1.z + vector2.z;
            Vector vector3 = new Vector(x3, y3, z3);
            //return vector1.x + (vector2.x * vector1.y) + (vector2.y * vector1.z) + vector2.z;
            return vector3;
        }
        // Перегрузка оператора -
        public static Vector operator -(Vector vector1, Vector vector2)
        {
            //return vector1.x - (vector2.x * vector1.y) - (vector2.y * vector1.z) - vector2.z;
            double x3 = vector1.x - vector2.x;
            double y3 = vector1.y - vector2.y;
            double z3 = vector1.z - vector2.z;
            Vector vector4 = new Vector(x3, y3, z3);
            return vector4;
        }
        // Перегрузка оператора *
        public static Vector operator *(Vector vector1, double sc)
        {
            double x = vector1.x * sc;
            double y = vector1.y * sc;
            double z = vector1.z * sc;
            Vector vector = new Vector(x, y, z);
            return vector;
        }
        public static void lenght(Vector vector1, Vector vector2)
        {
            double lenght1 = Math.Sqrt(Math.Pow(vector1.x, 2) + Math.Pow(vector1.y, 2) + Math.Pow(vector1.z, 2));
            double lenght2 = Math.Sqrt(Math.Pow(vector2.x, 2) + Math.Pow(vector2.y, 2) + Math.Pow(vector2.z, 2));
            Console.WriteLine("Длина 1-ого вектора равна: " + lenght1);
            Console.WriteLine("Длина 2-ого вектора равна: " + lenght2);
            
        }

    }
     
}
