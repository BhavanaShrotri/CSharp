using System;
using static System.Console;

namespace ConsoleApp
{
    class ExceptionReport
    {
        public ExceptionReport()
        {
            WriteLine("*********** Creating ExceptionReport *********** ");

            throw new Exception("Ex time: " + DateTime.Now.Ticks);
        }

        public void Run()
        {
            WriteLine("The report is good...");
        }
    }
}
