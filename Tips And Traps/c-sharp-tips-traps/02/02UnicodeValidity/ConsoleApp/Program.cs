using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp
{
    class Program
    {
        class Employee
        {
            public string FirstName { get; set; }
            public char EmployeeCode { get; set; }
            public int ProductivityRating { get; set; }
            public List<string> Skills { get; } = new List<string>();
            public string Bio { get; set; }
        }

        static void Main(string[] args)
        {
            var employee = new Employee();

            employee.FirstName = GetFirstName();
            employee.EmployeeCode = GetEmployeeCode();
            employee.ProductivityRating = GetProductivity();
            GetSkillsFor(employee);
            GetBioFor(employee);

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

        private static char GetEmployeeCode()
        {
            while (true)
            {
                WriteLine("Please enter employee code");

                char employeeCode = ReadLine().First(); // Additional validation omitted
                //employeeCode = (char)888;

                UnicodeCategory ucCategory = char.GetUnicodeCategory(employeeCode);

                bool isValidUnicode = ucCategory != UnicodeCategory.OtherNotAssigned;

                if (!isValidUnicode)
                {
                    WriteLine();
                    WriteLine("ERROR: Invalid employee code (invalid character)");
                }
                else
                {
                    return employeeCode;
                }
            }                       
        }

        private static int GetProductivity()
        {
            WriteLine("Please enter productivity rating (-100 to 100) enter 0 for new employees");
            
            int rating = int.Parse(ReadLine()); // Additional validation omitted

            return rating;
        }

        private static void GetSkillsFor(Employee employee)
        {
            // Simulate getting skills from user-input
            employee.Skills.Add("C#");
            employee.Skills.Add("HTML");
            employee.Skills.Add("SQL");
            employee.Skills.Add("JSON");
        }

        private static void GetBioFor(Employee employee)
        {
            // Simulate getting bio from user-input
            employee.Bio = "A darn hard working employee, dash it the best we have.";
        }

        private static void DisplayEmployee(Employee employee)
        {
            WriteLine("Employee Details");
            WriteLine("----------------");
            WriteLine();
            
            // TODO
        }

        private static bool IsAllWhiteSpace(string s)
        {
            if (s.Replace(" ", "").Length == 0) // doesn't take into accounts tabs
            {
                return true;
            }

            return false;
        }
    }
}

