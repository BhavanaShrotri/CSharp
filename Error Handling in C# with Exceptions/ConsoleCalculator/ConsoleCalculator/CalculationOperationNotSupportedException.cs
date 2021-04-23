using System;

namespace ConsoleCalculator
{
    class CalculationOperationNotSupportedException : CalculationException
    {
        public string Operation { get; }

        ///<summary>
        /// Creates a new <see cref="CalculationOperationNotSupportedException"/> with predefind message.
        /// </summary>
        public CalculationOperationNotSupportedException()
            :base("Specified operation was out of the range of valid values.")
        {

        }

        ///<summary>
        /// Creates a new <see cref="CalculationOperationNotSupportedException"/> with the operation that is not supported.
        /// </summary>
        public CalculationOperationNotSupportedException(string operation)
            :this()
        {
            Operation = operation;

        }

        ///<summary>
        /// Creates a new <see cref="CalculationOperationNotSupportedException"/> with user-supplied message and  a wrapped inner exception.
        /// </summary>
        public CalculationOperationNotSupportedException(string message,
            Exception innerException) : base(message,innerException)
        {

        }

        public CalculationOperationNotSupportedException(string operation, string message): base()
        {
            Operation = operation;
        }

        public override string Message
        {
            get 
            {
                string message = base.Message;

                if(Operation!=null)
                {
                    return message + Environment.NewLine + $"Unsupported operation: {Operation}";
                }

                return message;
            }
        }
    }
}
