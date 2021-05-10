using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;

namespace FileProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            JoinNamesAndAges();

            SetOperations();

            WriteLine("Press enter to exit");
            ReadLine();
        }



        private static void JoinNamesAndAges()
        {
            string[] names = File.ReadAllLines("Names.txt");
            string[] ages = File.ReadAllLines("Ages.txt");

            List<string> namesAndAges = Join(names, ages);
            Display(namesAndAges);

            List<string> namesAndAges2 = JoinV2(names, ages);
            Display(namesAndAges2);

            List<(string name, string age)> namesAndAges3 = JoinV3(names, ages);
            WriteLine();
            WriteLine("Output (tuple):");
            foreach (var tuple in namesAndAges3)
            {
                WriteLine($"{tuple.name},{tuple.age}");
            }

            string[] namesExtra = File.ReadAllLines("NamesExtra.txt");
            List<string> namesAndAges4 = JoinV2(namesExtra, ages);
            Display(namesAndAges4);

            void Display(IEnumerable<string> strings)
            {
                WriteLine();
                WriteLine("Output:");

                foreach (var @string in strings)
                {
                    WriteLine(@string);
                }
            }
        }

        private static List<string> Join(string[] names, string[] ages)
        {
            List<string> joined = new List<string>();

            for (int i = 0; i < names.Length; i++)
            {
                joined.Add($"{names[i]},{ages[i]}");
            }

            return joined;
        }

        private static List<string> JoinV2(string[] names, string[] ages)
        {
            //IEnumerable<string> joined = names.Zip(ages, CombineNameAndAge);
            //return joined.ToList();

            //return names.Zip(ages, CombineNameAndAge).ToList();

            return names.Zip(ages, (name, age) => $"{name},{age}").ToList();
        }


        private static List<(string name, string age)> JoinV3(string[] names, string[] ages)
        {
            return names.Zip(ages, (name, age) => (name, age)).ToList();
        }

        //private static string CombineNameAndAge(string name, string age)
        //{
        //    return $"{name},{age}";
        //}

        private static void SetOperations()
        {
            WriteLine();
            WriteLine("Please enter first sequence of ints (separated by commas):");
            IEnumerable<int> firstSequence = ReadLine().Split(',').Select(x => int.Parse(x));

            WriteLine("Please enter second sequence of ints (separated by commas):");
            IEnumerable<int> secondSequence = ReadLine().Split(',').Select(x => int.Parse(x));


            IEnumerable<int> concat = firstSequence.Concat(secondSequence);
            Display(concat, "Concat results");

            IEnumerable<int> union = firstSequence.Union(secondSequence);
            Display(union, "Union results");

            IEnumerable<int> intersect = firstSequence.Intersect(secondSequence);
            Display(intersect, "Intersect results");

            IEnumerable<int> except = firstSequence.Except(secondSequence);
            Display(except, "Except results");

            string[] names = new[] { "Sarah", "Gentry", "Amrit" };
            IEnumerable<string> namesResult = names.Except(new[] { "Sarah", "Amrit", "Mark" });
            Display(namesResult, "String Except results");

            void Display<T>(IEnumerable<T> items, string title)
            {
                WriteLine();
                WriteLine(title);
                foreach (var item in items)
                {
                    WriteLine(item);
                }
            }
        }
    }
}
