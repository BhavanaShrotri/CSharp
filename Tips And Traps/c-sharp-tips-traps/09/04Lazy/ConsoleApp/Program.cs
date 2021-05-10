using System;
using System.Collections;
using System.Globalization;
using System.Threading;
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
            // Culture names format: languagecode-countryregioncode
            const string australiaCultureString = "en-AU";
            const string turkeyCultureString = "tr-TR";
            const double someNumber = 23.45;

            WriteLine("Setting English language - Australia country/region");
            CultureInfo australiaCultureInfo = CultureInfo.GetCultureInfo(australiaCultureString);
            Thread.CurrentThread.CurrentCulture = australiaCultureInfo;

            WriteLine(someNumber);
            WriteLine(DateTime.Now);

            WriteLine("Setting Turkish language - Turkey country/region");
            CultureInfo turkeyCultureInfo = CultureInfo.GetCultureInfo(turkeyCultureString);
            Thread.CurrentThread.CurrentCulture = turkeyCultureInfo;

            WriteLine(someNumber);
            WriteLine(DateTime.Now);
        }

        private static void RunReport()
        {
            //Report report = new Report();

            //WriteLine("Would you like to run the report? Y/N");
            //string choice = ReadLine();

            //if (choice == "Y")
            //{
            //    WriteLine($"Report Name: {report.ReportName}");
            //    report.Run();
            //}

            Lazy<Report> report = new Lazy<Report>(() => new Report("Sales Report"));

            WriteLine("Would you like to run the report? Y/N");
            string choice = ReadLine();

            if (choice == "Y")
            {
                WriteLine($"Report Name: {report.Value.ReportName}");
                report.Value.Run();
            }
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

