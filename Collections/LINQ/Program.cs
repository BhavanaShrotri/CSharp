using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Patient> patients = new List<Patient>();

            Patient p1 = new Patient();
            p1.PatientName = "Deepak Joshi";
            p1.Area = "UP";
            p1.Age = 25;
            p1.Gender = "Male";
            patients.Add(p1);


            Patient p2 = new Patient();
            p2.PatientName = "Bhavana Shrotri";
            p2.Area = "Maharashtra";
            p2.Age = 19;
            p2.Gender = "Female";
            patients.Add(p2);


            Patient p3 = new Patient();
            p3.PatientName = "Arju Mulla";
            p3.Area = "Maharashtra";
            p3.Age = 21;
            p3.Gender = "Female";
            patients.Add(p3);

            var mypatient = from pa in patients
                            where pa.Age > 20
                            orderby pa.PatientName, pa.Gender, pa.Age
                            select pa;

            foreach (var pp in mypatient)
            {
               Console.WriteLine(pp.PatientName + " " + pp.Age + " " + pp.Gender);
            }

            int patientCount = (from pa in patients
                                where pa.Age > 20
                                orderby pa.PatientName, pa.Gender, pa.Age
                                select pa).Count();

            Console.WriteLine("Patient Count who's age above 20 is : " + patientCount);


            //Multiple select

            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            var pairs = from a in numbersA from b in numbersB where a < b select new { a, b };
            Console.WriteLine("Pairs where a < b:");
            foreach (var pair in pairs)
            {
                Console.WriteLine("{0} is less than {1}", pair.a, pair.b);
            }

            // OrderBy 
            string[] words = { "cherry", "apple", "blueberry" };
            var sortedWords = from w in words orderby w select w;
            Console.WriteLine("The sorted list of words:");
            foreach (var w in sortedWords)
            {
                Console.WriteLine(w);
            }

        Console.ReadKey();
        }
    }
}
