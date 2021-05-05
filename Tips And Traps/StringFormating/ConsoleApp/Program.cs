using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
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

                char employeeCode = ReadLine().First();

                UnicodeCategory uCategory = char.GetUnicodeCategory(employeeCode);

                bool isvalidUnicode = uCategory != UnicodeCategory.OtherNotAssigned;

                if (!isvalidUnicode)
                {
                    WriteLine();
                    WriteLine("ERROR : Invalid employee code (invalid character )");
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

            //WriteLine("First Name : " + employee.FirstName + " Employee Code : " + employee.EmployeeCode);
            //string line = string.Format("First Name : {0} Employee Code: {1}",
            //                            employee.FirstName,
            //                            employee.EmployeeCode);

            //WriteLine(line);

            //WriteLine("First Name : {0} Employee Code: {1}",
            //                            employee.FirstName,
            //                            employee.EmployeeCode);


            WriteLine($"First Name : {employee.FirstName} Employee Code: {employee.EmployeeCode}");

            string theHardWay = "First Name : " + employee.FirstName.PadRight(20) + "Employee Code : " + employee.EmployeeCode.ToString().PadRight(5);

            WriteLine(theHardWay);


            string easier = string.Format("First Name : {0,-20} Employee Code: {1,-5}",employee.FirstName,employee.EmployeeCode);

            WriteLine(easier);

            WriteLine($"First Name : {employee.FirstName,-20} Employee Code: {employee.EmployeeCode,-5}");
            WriteLine($"First Name : {employee.FirstName,20} Employee Code: {employee.EmployeeCode,5}");

            WriteLine($"Productivity Rating : {employee.ProductivityRating}");

            const string ThreePartFormat = "(Good Employee) #;(Bad Employee) -#;(New Employee)";

            WriteLine(employee.ProductivityRating.ToString(ThreePartFormat));


            string skills = " ";
            foreach(var skill in employee.Skills)
            {
                skills += $"{skill}, ";
            }

            WriteLine($"Skills : {skills}");


            var sb = new StringBuilder();

            foreach (var skill in employee.Skills)
            {
                sb.Append(skill);
                sb.Append(", ");
            }

            WriteLine($"Skills : {sb}");

            string prod = string.Format(new EmployeeProductivityFormatProvider(),
                "Productivity rating : {0}",employee.ProductivityRating);

            WriteLine(prod);
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

