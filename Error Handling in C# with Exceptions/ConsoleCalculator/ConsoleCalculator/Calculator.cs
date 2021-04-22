using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculator
{
    class Calculator
    {
        public int Calculate(int number1, int number2, string operation)
        { 
            if(operation == "/")
            {
                return Divide(number1, number2); 
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
