using System.Collections.Generic;

namespace ConsoleApp
{
    partial class Program
    {
        class Employee
        {
            public string FirstName { get; set; }
            public char EmployeeCode { get; set; }
            public int ProductivityRating { get; set; }
            public List<string> Skills { get; } = new List<string>();
            public string Bio { get; set; }
        }

    }
}
