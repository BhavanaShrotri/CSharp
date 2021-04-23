using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculator
{
    class Calculator
    {
        public int Calculate(int number1, int number2, string operation)
        {
            //throw new ArgumentNullException(nameof(number1));
            string nonNullOperation =
                operation ?? throw new ArgumentNullException(nameof(operation));
            //if (operation is null)
            //{
            //    throw new ArgumentNullException(nameof(operation));
            //}
            if(nonNullOperation == "/")
            {
                try
                {
                    return Divide(number1, number2);
                }
                catch(DivideByZeroException ex)
                {
                    //throw;
                    throw new ArithmeticException("An error occured during calculation");
                }    
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(operation),
                    "Mathematical operator is not supported.");
                //Console.WriteLine("Unkown Operation");
                //return 0;
            }
        
        }

        private int Divide(int number, int divisor)
        {
            return number / divisor;
        }
    }
}
