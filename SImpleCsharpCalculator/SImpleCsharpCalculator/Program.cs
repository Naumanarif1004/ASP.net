using System;

namespace SImpleCsharpCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            bool ch = true;
            var handler = new CalculatorHandling();
            int choice = new int();
            int no1 = new int();
            int no2 = new int();
            float result=new float();
            Console.WriteLine("-----Calculator------");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            Console.WriteLine(">4.Break");

            do
            {
                Console.WriteLine("\nEnter your choice:");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 5)
                {
                    Console.WriteLine("\nEnter First number:");
                    no1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Second number:");
                    no2 = Convert.ToInt32(Console.ReadLine());
                }

                switch (choice)
                {
                    
                    case 1:
                        result = handler.Add(no1, no2);
                        Console.WriteLine($"\nAddition of Two Numbers :: {no1} + {no2} = {result}");
                        break;
                    case 2:
                        result = handler.Sub(no1, no2);
                        Console.WriteLine($"\nSubtraction of Two Numbers :: {no1} - {no2} = {result}");
                        break;
                    case 3:
                        result = handler.Mult(no1, no2);
                        Console.WriteLine($"\nMultiplication of Two Numbers ::  {no1} * {no2} = {result}");
                        break;
                    case 4:
                        try
                        {
                            result = handler.Divide(no1, no2);
                        }
                        catch (Exception e)
                        {

                            Console.WriteLine(e.Message);
                            ch= false;
                        }
                        if (ch == true)
                        {
                            Console.WriteLine($"\nDivision of Two Numbers :: {no1} * {no2} = {result}");
                        }
                      
                        break;
                    default:
                        Console.WriteLine("Invalid entry......");
                        check = false;
                        break;
                }
                
            } while (check);
            Console.ReadKey();


        }
    }
}
