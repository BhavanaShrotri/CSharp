using System;

namespace ConsoleCalculator
{
    public class CalculationException : Exception
    {

        private static readonly string DefaultMessage = "An error occur during calculation " +
            "Ensure that the operation is supported and that the value are " +
            "within the valid ranges for the requested operation.";



        ///<summary>
        /// Creates a new <see cref="CalculationException"/> with predefind message.
        /// </summary>
        public CalculationException() :base(DefaultMessage)
        {

        }

        ///<summary>
        /// Creates a new <see cref="CalculationException"/> with user-supplied message.
        /// </summary>
        public CalculationException(string message):base (message)
        {

        }

        ///<summary>
        /// Creates a new <see cref="CalculationException"/> with predefind message and  a wrapped inner exception.
        /// </summary>
        public CalculationException(Exception innerException):base(DefaultMessage,innerException)
        {

        }

        ///<summary>
        /// Creates a new <see cref="CalculationException"/> with user-supplied message and  a wrapped inner exception.
        /// </summary>
        public CalculationException(string message,Exception innerException):base(message,innerException)
        {

        }
    }
}
