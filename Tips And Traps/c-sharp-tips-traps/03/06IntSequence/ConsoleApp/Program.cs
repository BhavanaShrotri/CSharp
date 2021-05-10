using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
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
            public BigInteger Salary { get; set; }
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

            string input = ReadLine();

            // DateTime dob = DateTime.Parse(input);
            DateTime dob = DateTime.ParseExact(input, "MM/dd/yyyy", null);

            DateTime d1 = DateTime.Parse("01/12/2000");
            DateTime d2 = DateTime.Parse("01/12/2000", null, DateTimeStyles.AssumeUniversal);
            DateTime d3 = DateTime.Parse("01/12/2000", null, DateTimeStyles.AssumeLocal);
            DateTime d4 = DateTime.Parse("13:30:00"); // Defaults to DateTimeStyles.None
            DateTime d5 = DateTime.Parse("13:30:00", null, DateTimeStyles.NoCurrentDateDefault);

            return dob;
        }

        private static BigInteger GetSalary()
        {
            WriteLine("Please enter salary");

            string input = ReadLine(); // error checking code omitted

            //int value = int.Parse(input);

            BigInteger value = BigInteger.Parse(input);

            value++;
            value--;
            value = value * 2;

            //var biggest = Math.Max(0, value);
            var biggest = BigInteger.Max(0, value);

            return value;
        }

        private static int GenerateRandomId()
        {
            using (RNGCryptoServiceProvider rnd = new RNGCryptoServiceProvider())
            {
                byte[] randomBytes = new byte[4];

                rnd.GetBytes(randomBytes);

                int result = BitConverter.ToInt32(randomBytes, 0);

                return result;
            }


            //Random rnd = new Random(); // system clock as seed value
            //Random rnd2 = new Random(42); // explicit seed value
            //Random rnd3 = new Random(42); // explicit seed value

            //int x = rnd2.Next();
            //int y = rnd3.Next();
            //int z = rnd.Next();

            //Random r1 = new Random();
            //Random r2 = new Random();

            //int r1Value = r1.Next();
            //int r2Value = r2.Next();


            //return rnd.Next();
        }

        private static List<int> GenerateDefaultWorkDays()
        {
            //var days = new List<int>();

            //for (int i = 1; i <= 5; i++)
            //{
            //    days.Add(i);
            //}

            //return days;

            return Enumerable.Range(1, 5).Select(x => x * 2).ToList();
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



