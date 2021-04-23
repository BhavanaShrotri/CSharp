using System;
using System.IO;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            AppDomain currentAppDomain = AppDomain.CurrentDomain;
            currentAppDomain.UnhandledException
                += new UnhandledExceptionEventHandler(HandleException);
            
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
            catch(ArgumentNullException ex) when (ex.ParamName =="operation")
            {
                Console.WriteLine($"Operation was not provided. {ex}");
            }
            catch (ArgumentNullException ex) 
            {
                Console.WriteLine($"An Argument was Null{ex}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Operation was not provided. {ex}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Sorry Somthing Went Wrong. {ex}");
            } 
            finally
            {
                Console.WriteLine("....Finally.....");
            }
       
        }

        private static void HandleException(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine($"Sorry there was a problem and we need to close. Details : {e.ExceptionObject}");
        }

        private static void DisplayResult(int result)
        {
            Console.WriteLine($"Result is :{result}");
        }
    }
}
