using System;

namespace GuidGeneratorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Guid.NewGuid()); // Creates standard output
            throw new Exception("Something went wrong after GUID generation."); // Creates error output
        }        
    }
}
