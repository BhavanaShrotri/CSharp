using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp
{
    partial class Program
    {

        static void Main(string[] args)
        {
            Project project1 = new Project { Name = "Better UI" };
            // Project project2 = new AgileProject { Name = "Better UI" };


            List<Person> team = new List<Person>
            {
                new Person("Sarah"),
                new Person("Amrit", 22),
                new Person("Anna", 42, "female")
            };

            DisplayTeam(team);

            WriteLine();
            DisplayPerson("The team:", team[0]);


            WriteLine();
            Display("First person in team", team[0]);

            WriteLine();
            Display("Project and leader", project1, team[0]);


            WriteLine();
            WriteLine("Press enter to exit.");
            ReadLine();
        }

        private static void DisplayTeam(List<Person> team)
        {
            WriteLine("Team");
            WriteLine("----");
            foreach (var person in team)
            {
                WriteLine($"{person.Name,-20} {person.Age,-5} {person.Gender,-10}");
            }
        }

        private static void DisplayPerson(string title, Person person)
        {
            WriteLine(title);
            WriteLine($"{person.Name,-20} {person.Age,-5} {person.Gender,-10}");
        }

        private static void Display(string title, object o)
        {
            WriteLine(title);
            WriteLine(o);
        }

        private static void Display(string title, object o, object o2)
        {
            WriteLine(title);
            WriteLine(o);
            WriteLine(o2);
        }
  

    }
}
