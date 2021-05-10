using System;
using System.Collections.Generic;
using System.Globalization;
using static System.Console;

namespace ConsoleApp
{
    class Program
    {
        class Employee
        {
            public string FirstName { get; set; }
            public int ProductivityRating { get; set; }
            public DateTime DateOfBirth { get; set; }
            public int Salary { get; set; }
            public int Id { get; set; }
            public List<int> WorkDays { get; set; }
        }

        static void Main(string[] args)
        {
            var employee = new Employee();

            employee.FirstName = GetFirstName();
            employee.ProductivityRating = GetProductivity();
            employee.DateOfBirth = GetDateOfBirth();
            employee.Salary = GetSalary();
            employee.Id = GenerateRandomId();
            employee.WorkDays = GenerateDefaultWorkDays();

            DisplayEmployee(employee);


            WriteLine();
            WriteLine("Press enter to exit.");
            ReadLine();
        } 

        private static string GetFirstName()
        {
            while (true)
            {
                WriteLine("Please enter first name");

                string firstName = ReadLine();

                if (string.IsNullOrWhiteSpace(firstName))
                {
                    WriteLine("ERROR: Invalid first name");
                }
                else
                {
                    return firstName;
                }
            }
        }

        private static int GetProductivity()
        {
            WriteLine("Please enter productivity rating (-100 to 100) enter 0 for new employees");

            string input = ReadLine();

            int rating = int.Parse(input, 
                NumberStyles.AllowParentheses | NumberStyles.AllowTrailingSign);

            return rating;
        }

        private static DateTime GetDateOfBirth()
        {
            WriteLine("Please enter date of birth");

            // TODO

            return DateTime.Now;
        }

        private static int GetSalary()
        {
            WriteLine("Please enter salary");

            string input = ReadLine(); // error checking code omitted

            int value = int.Parse(input);
          
            return value;
        }

        private static int GenerateRandomId()
        {
            // TODO

            return 0;
        }

        private static List<int> GenerateDefaultWorkDays()
        {
            // TODO

            return new List<int>();
        }

        private static void DisplayEmployee(Employee employee)
        {
            WriteLine($"First Name: {employee.FirstName}");

            const string threePartFormat = "(good employee) #;(bad employee) -#;(new employee - no productivity recorded yet)";
            WriteLine(employee.ProductivityRating.ToString(threePartFormat));

            WriteLine($"DOB: {employee.DateOfBirth}");

            WriteLine($"Salary: {employee.Salary}");

            WriteLine($"Id: {employee.Id}");

            WriteLine($"Work Days: {string.Join(",", employee.WorkDays)}"); 
        }
    }
}



