using System;
using Vector;
using Multimember;

namespace Program
{
    class Program
    {
       
        static void Main (string[] args)
        {
         
        Start:
            try { 
            Console.WriteLine("\nВыберите задание:\n1.Вектор\n2.Многочлен\n3.Выход\n");
            int c = Int32.Parse(Console.ReadLine());
            switch (c)
            {
                case 1:
                    try
                    {
                        Task1.vector();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error Message:  {0}", e.Message);
                        goto Start;
                    }
                    break;
                case 2:
                    try
                    {
                        Task2.Multimember(); ;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error Message:  {0}", e.Message);
                        goto Start;
                    }
                    break;
                case 3:                       

                    break;

                default:

                    Console.WriteLine("Неверное значение");
                    goto Start;
            }
            
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Message:  {0}", e.Message);
                goto Start;
            }
        }
    }
    
     
}
