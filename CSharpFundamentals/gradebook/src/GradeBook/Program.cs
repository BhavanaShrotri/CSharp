using System;
using System.Collections.Generic;

namespace GradeBook
{
    
    class Program
    {
        static void Main(string[] args)
        {

            IBook book1 = new DiskBook("Bhavana's GradeBook");

            book1.GradeAdded += OnGradeAdded;

            EnterGrades(book1);

            var stats = book1.GetStatistics();

            Console.WriteLine($"The lowest grade is : {stats.Low}");
            Console.WriteLine($"The highest grade is : {stats.High}");
            Console.WriteLine($"The Avg grade is : {stats.Avg}");
            Console.WriteLine($"The Letter grade is : {stats.Letter}");


            static void OnGradeAdded(object sender, EventArgs e)
            {
                Console.WriteLine("A grade was Added..");
            }

        }

        private static void EnterGrades(IBook book1)
        {
            while (true)
            {
                Console.WriteLine("Enter a grede or 'q' to quit : ");

                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }
                try
                {
                    var grade = double.Parse(input);
                    book1.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("******");
                }

            }
        }
    }
}
