using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {


            // Read the contents of the CSV files as individual lines
            string[] csvLines = System.IO.File.ReadAllLines(@"C:\Users\shro_bha\Desktop\My Code\Collections\List\grades.csv");

            // Create lists with the CSV data
            var students = new List<Student>();

            // Split each row into column data
            for (int i = 1; i < csvLines.Length; i++)
            {
                Student st = new Student(csvLines[i]);
                students.Add(st);
            }

            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i]);
            }


            Console.ReadKey();
        }
    }
}