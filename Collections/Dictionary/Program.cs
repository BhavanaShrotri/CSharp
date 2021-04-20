using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static public void Main()
        {



            Dictionary<int, string> Student = new Dictionary<int, string>();

            Student.Add(101, "Bhavana");
            Student.Add(102, "Rachana");
            Student.Add(103, "Shreya");

            foreach (KeyValuePair<int, string> stud in Student)
            {
                Console.WriteLine("{0} and {1}", stud.Key, stud.Value);
            }
            Console.WriteLine();

           
            Student.Remove(102);  //Remove Element 


            // Display After Removing Element 
            foreach (KeyValuePair<int, string> stud in Student)
            {
                Console.WriteLine("{0} and {1}", stud.Key, stud.Value);
            }
            Console.WriteLine();


        }
    }

}