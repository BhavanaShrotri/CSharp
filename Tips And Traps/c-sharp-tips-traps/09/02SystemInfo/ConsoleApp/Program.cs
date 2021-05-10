using System;
using System.Collections;
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
            IDictionary envVars = Environment.GetEnvironmentVariables();
            WriteLine(envVars["Path"]);

            WriteLine($"64 bit OS: {Environment.Is64BitOperatingSystem}");
            WriteLine($"64 bit process: {Environment.Is64BitProcess}");
            WriteLine($"Number of processor: {Environment.ProcessorCount}");
            WriteLine($"OS memory page: {Environment.SystemPageSize} bytes");

            string currEnvNewLineString = Environment.NewLine;
            // "\r\n" non-Unix or "\n" for Unix platforms

            WriteLine($"Current dir: {Environment.CurrentDirectory}");
            WriteLine($"Desktop dir: {Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)}");
            WriteLine($"Fonts dir: {Environment.GetFolderPath(Environment.SpecialFolder.Fonts)}");
            WriteLine($"My Documents dir: {Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}");
            WriteLine($"Startup dir: {Environment.GetFolderPath(Environment.SpecialFolder.Startup)}");

            string[] drives = Environment.GetLogicalDrives();
            WriteLine($"Drives: {string.Join(" ", drives)}");

            WriteLine($"System dir: {Environment.SystemDirectory}");
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

