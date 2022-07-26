using System;
using System.Linq;

namespace lab5
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Вариант 7\nЗадание 1, 2, 3:");
            int c = Int32.Parse(Console.ReadLine());
            switch (c)
            {
                //Task 1
                case 1:
                    double sum = 0;
                    int elementsCount = 0;
                    double[] myArray;

                Start1:
                    Console.WriteLine("Введите количество элементов массива: ");
                    try
                    {
                        elementsCount = int.Parse(Console.ReadLine());
                        myArray = new double[elementsCount];
                        for (int i = 0; i < myArray.Length; i++)
                        {
                            Console.WriteLine($"Ввод {i} элемента массива: ");
                            myArray[i] = Double.Parse(Console.ReadLine());
                        }

                        for (int i = 0; i < myArray.Length; i++)
                        {
                            if (myArray[i] < 0)
                            {
                                i++;
                                for (; i < myArray.Length; i++)
                                {
                                    sum += Math.Abs(myArray[i]);

                                }

                            }
                        }
                        Console.WriteLine($"Сумма модулей элементов массива, расположенных после первого отрицательного элемента:{sum} ");

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error Message:  {0}", e.Message);
                        goto Start1;
                    }
                    break;
                // Task 2
                case 2:
                    double[] myArray2;
                    bool isTrue = true;                  
                    Start2:
                    Console.WriteLine("Введите количество элементов массива: ");
                    try
                    {
                        elementsCount = int.Parse(Console.ReadLine());
                        myArray = new double[elementsCount];
                        myArray2 = new double[elementsCount];

                        for (int i = 0; i < myArray.Length; i++)
                        {
                            Console.WriteLine($"Ввод {i} элемента массива: ");
                            myArray[i] = Double.Parse(Console.ReadLine());
                        }
                        // Sort
                        for (int i = 0; i < myArray.Length; i++)
                        {
                            if (myArray[i] == 0 && isTrue == true )
                            {
                                Array.Sort(myArray2);
                                Array.Reverse(myArray2);
                                isTrue = false;
                                
                            }
                            else
                            {                            
                                myArray2[i]  = myArray[i];         
                            }
                        }
                        
                        

                        Console.WriteLine("Отсортированные элементы массива по убыванию до первого элемента, равного нулю:  ");
                        for (int i = 0; i < myArray2.Length; i++)
                        {
                            Console.WriteLine(myArray2[i]);
                            
                        }
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Error Message:  {0}", e.Message);
                        goto Start2;
                    }
                        break;
                // Task 3
                case 3:
                Start3:
                    double[,] myArray3;
                    int n = 0;
                    int m = 0;
                    double summ = 0;
                    //Random random = new Random();
                    Console.WriteLine("Ввод вещественной прямоугольной матрицы n*m: ");
                    try
                    {
                        //Input
                        Console.WriteLine("Ввод n: ");
                        n = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ввод m: ");
                        m = int.Parse(Console.ReadLine());
                        myArray3 = new double[n,m];

                        for(int i = 0; i < myArray3.GetLength(0); i++)
                        {
                            for (int j = 0; j < myArray3.GetLength(1); j++)
                            {
                                //myArray3[i, j] = random.Next(-20, 50);
                                Console.WriteLine("Y: "+ i + " " + "X: " + j);
                                myArray3[i, j] = double.Parse(Console.ReadLine());
                            }
                        }

                        Console.WriteLine();

                        // Output
                        for (int y = 0; y < myArray3.GetLength(0); y++)
                        {
                            for (int x = 0; x < myArray3.GetLength(1); x++)
                            {
                                Console.Write(myArray3[y,x] + "\t");
                            }
                            Console.WriteLine();
                        }

                        //Summ
                        int flag = 0;
                        for (int i = 0; i < myArray3.GetLength(0); i++)
                        {
                            for (int j = 0; j < myArray3.GetLength(1); j++)
                                if (myArray3[i,j] < 0)
                                    flag = 1;
                            if (flag == 1)
                            {
                                for (int z = 0; z < myArray3.GetLength(1); z++)
                                {
                                    summ += myArray3[i,z];
                                    
                                }

                                Console.WriteLine($"Сумма элементов в тех строках({i}), которые содержат хотя бы один отрицательный \nэлемент: " + summ);
                            }
                            flag = 0;
                            summ = 0;
                        }
                        
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error Message:  {0}", e.Message);
                        goto Start3;
                    }
                    break;
                default:
                    Console.WriteLine("Неверное значение");
                    break;
            }
            
            

        }
    }
}
