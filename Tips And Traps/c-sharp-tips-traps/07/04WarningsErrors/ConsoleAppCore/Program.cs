using System;
using System.Text;
using Utilities;
using static System.Console;

namespace ConsoleAppCore
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Hi";
            StringBuilder b = new StringBuilder();            

            WriteLine($"variable {nameof(a)} is from {TypeUtils.GetNamespace(a)}");
            WriteLine($"variable {nameof(b)} is from {TypeUtils.GetNamespace(b)}");

            WriteLine("Press enter to exit.");
            ReadLine();
        }
    }
}
