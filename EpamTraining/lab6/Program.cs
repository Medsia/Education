using System;

namespace lab6
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Вариант 7\nЗадание 1, 2, 3, 4:");
            int c = Int32.Parse(Console.ReadLine());
            int elementsCount;
            double[] myArray;
            switch (c)
            {
                //Task 1
                case 1:
                    double sum = 0;                                      
                Start1:                   
                    try
                    {                     
                        myArray = InputArray();                     
                        SummAbs(myArray, ref sum);  // using ref
                    
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
                    try
                    {
                        myArray = InputArray();
                        myArray2 = new double[elementsCount];                      
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
                    double summ = 0;
                    Console.WriteLine("Ввод вещественной прямоугольной матрицы n*m: ");
                    try
                    {
                        myArray3 = InputMatrix(out myArray3); //using out

                        Console.WriteLine();

                        OutputMatrix(myArray3);
                     
                        //Sum
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
                                    summ += myArray3[i, z];
                                    
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

                // Task 4
                
                case 4:
                    
                Start4:
         
                    try
                    {
                        Task4.task4();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error Message:  {0}", e.Message);
                        goto Start4;
                    }
                    break;
                    
                default:
                    Console.WriteLine("Неверное значение");
                    break;
            }

            double[] InputArray()
            {
                Console.WriteLine("Введите количество элементов массива: ");               
                
                elementsCount = int.Parse(Console.ReadLine());
                myArray = new double[elementsCount];

                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.WriteLine($"Ввод {i} элемента массива: ");
                    myArray[i] = Double.Parse(Console.ReadLine());
                }
                return myArray;
            }

            double[,] InputMatrix(out double[,] myArray3) // using out
            {
                //double[,] myArray3;
                int n = 0;
                int m = 0;

                Console.WriteLine("Ввод n: ");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("Ввод m: ");
                m = int.Parse(Console.ReadLine());
                myArray3 = new double[n, m];

                for (int i = 0; i < myArray3.GetLength(0); i++)
                {
                    for (int j = 0; j < myArray3.GetLength(1); j++)
                    {
                        Console.WriteLine("Y: " + i + " " + "X: " + j);
                        myArray3[i, j] = double.Parse(Console.ReadLine());
                    }
                }
                return myArray3;
            }

            void OutputMatrix(double[,] myArray3)
            {
                for (int y = 0; y < myArray3.GetLength(0); y++)
                {
                    for (int x = 0; x < myArray3.GetLength(1); x++)
                    {
                        Console.Write(myArray3[y, x] + "\t");
                    }
                    Console.WriteLine();
                }
                
            }

            void SummAbs(double [] myArray,ref double sum) //using ref
            {
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

            /*double Sum(params double[] parameters) // using Params
            {
                double result = 0;
                for (int i = 0; i < parameters.Length; i++)
                {
                    result += parameters[i];
                }

                return result;
            }*/



        }

    }
}
