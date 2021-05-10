using System;

namespace GuidGeneratorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Guid.NewGuid());
           // throw new Exception("Something went wrong with GUID generation.");
        }        
    }
}
