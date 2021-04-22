using System;
using System.IO;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter First Number : ");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number : ");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Operation: ");
            string operation = Console.ReadLine().ToUpperInvariant();

            var calculator = new Calculator();

            try
            {
                int result = calculator.Calculate(number1, number2, operation);
                DisplayResult(result);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Sorry Somthing Went Wrong. {ex}");
            } 


            

        }

        private static void DisplayResult(int result)
        {
            Console.WriteLine($"Result is :{result}");
        }
    }
}
