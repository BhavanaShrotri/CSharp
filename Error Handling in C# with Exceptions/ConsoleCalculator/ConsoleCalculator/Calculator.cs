using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculator
{
    public class Calculator
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
                catch(ArithmeticException ex)
                {
                    //throw;
                    throw new CalculationException("An Error Code Occur During Division",ex);
                }    
            }
            else
            {
                throw new CalculationOperationNotSupportedException(operation);
            }
        
        }

        private int Divide(int number, int divisor)
        {
            return number / divisor;
        }
    }
}
