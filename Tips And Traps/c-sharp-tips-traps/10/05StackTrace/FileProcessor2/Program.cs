using System;
using System.Collections.Generic;
using static System.Console;

namespace FileProcessor2
{
    class Program
    {
        static void Main(string[] args)
        {
            Processor processor = new Processor();

            try
            {
                List<Person> people = processor.Process("Names.txt", "missing.txt");

                foreach (var person in people)
                {
                    WriteLine($"{person.Name},{person.Age}");
                }
            }
            catch (Exception ex)
            {
                WriteLine(ex);
            }


            WriteLine();
            WriteLine("Press enter to exit");
            ReadLine();
        }
    }
}
