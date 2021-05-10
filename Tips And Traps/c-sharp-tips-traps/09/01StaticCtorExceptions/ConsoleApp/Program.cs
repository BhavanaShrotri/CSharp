using System;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Greet();

            DisplaySystemInfo();

            ChangeCulture();

            RunReport();

            RunExternal();


            WriteLine("Press enter to exit");
            ReadLine();
        }

        private static void Greet()
        {
            try
            {
                Write(GreetingGenerator.GreetingPrefix);
            }
            catch (Exception ex)
            {
                WriteLine(ex.ToString());
                WriteLine("Please press enter to proceed.");
                ReadLine();
            }


            GreetingGenerator generator = new GreetingGenerator();
            WriteLine(generator.Generate());
        }

        private static void DisplaySystemInfo()
        {

        }


        private static void ChangeCulture()
        {

        }

        private static void RunReport()
        {

        }

        private static async Task<string> LoadFile(string fileName)
        {
            return "";
        }

        private static void RunExternal()
        {
        
        }
    }
}

