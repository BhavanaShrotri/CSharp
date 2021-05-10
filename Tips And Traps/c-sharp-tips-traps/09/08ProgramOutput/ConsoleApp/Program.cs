using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.IO;
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

            // RunReport();

            string fileContents = await LoadFile("fruit.txt");
            WriteLine(fileContents);

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

            //Lazy<Report> report = new Lazy<Report>(() => new Report("Sales Report"));

            //WriteLine("Would you like to run the report? Y/N");
            //string choice = ReadLine();

            //if (choice == "Y")
            //{
            //    WriteLine($"Report Name: {report.Value.ReportName}");
            //    report.Value.Run();
            //}

            //Lazy<ExceptionReport> report = new Lazy<ExceptionReport>(); // no exception caching
            Lazy<ExceptionReport> report = new Lazy<ExceptionReport>(() => new ExceptionReport()); // with exception caching

            try
            {
                report.Value.Run();
            }
            catch (Exception ex)
            {
                WriteLine(ex);
            }

            try
            {
                report.Value.Run();
            }
            catch (Exception ex)
            {
                WriteLine(ex);
            }
        }

        private static async Task<string> LoadFile(string fileName)
        {
            const int totalRetryAttemptsAllowed = 10;
            int retryAttemptsRemaining = totalRetryAttemptsAllowed;

            while (retryAttemptsRemaining > 0)
            {
                try
                {
                    bool isFirstAttempt = retryAttemptsRemaining == totalRetryAttemptsAllowed;

                    if (!isFirstAttempt)
                    {
                        WriteLine("Waiting before trying again...");
                        await Task.Delay(2000);
                    }

                    WriteLine($"{DateTime.Now.ToShortTimeString()} Opening file '{fileName}': attempt {retryAttemptsRemaining}");
                    using (var file = File.OpenText(fileName))
                    {
                        return await file.ReadToEndAsync();
                    }
                }
                catch (Exception)
                {
                    retryAttemptsRemaining--;
                }
            }

            return $"ERROR: Cannot open file '{fileName}'";
        }

        private static void RunExternal()
        {
            //WriteLine("Opening notepad.exe");
            //Process.Start("notepad.exe");

            WriteLine("Opening notepad.exe with args");
            WriteLine("Please enter your favorite dessert");
            string dessert = ReadLine();
            string dessertFilePath =
                Path.Combine(Environment.CurrentDirectory, "dessert.txt");
            File.WriteAllText(dessertFilePath, dessert);

            //Process.Start("notepad.exe", dessertFilePath);

            ProcessStartInfo notepadStartInfo = new ProcessStartInfo
            {
                FileName = "notepad.exe",
                Arguments = dessertFilePath,
                WindowStyle = ProcessWindowStyle.Maximized
            };

            //Process.Start(notepadStartInfo);

            WriteLine("Opening cmd.exe");

            ProcessStartInfo cmdStartInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/C DATE /T",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false // allows redirection of output
            };

            Process cmdProcess = Process.Start(cmdStartInfo);

            string dateFromCommandLine = cmdProcess.StandardOutput.ReadToEnd();
            string error = cmdProcess.StandardError.ReadToEnd();

            WriteLine("Standard output from process:");
            WriteLine(dateFromCommandLine);
            WriteLine("Error:");
            WriteLine(error);




            // Additional error output example:

            // See the GuidGeneratorConsoleApp project (program.cs) in the solution which is referenced from 
            // this console app - so the GuidGeneratorConsoleApp.exe executable will be copied to ConsoleApp\bin\Debug


            WriteLine("Opening GuidGeneratorConsoleApp.exe");
            ProcessStartInfo guidGenerator = new ProcessStartInfo
            {
                FileName = Path.Combine(Environment.CurrentDirectory, "GuidGeneratorConsoleApp.exe"),
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false
            };

            Process guidProcess = Process.Start(guidGenerator);

            string guidOutput = guidProcess.StandardOutput.ReadToEnd();
            string guidError = guidProcess.StandardError.ReadToEnd();

            WriteLine("Generated Guid:");
            WriteLine(guidOutput);

            WriteLine("Error:");
            WriteLine(guidError);

            // Usually a zero exit code represents no error/successful execution of the program
            
            // "The ExitCode value for a process reflects the specific convention implemented by the 
            //  application developer for that process. If you use the exit code value to make decisions 
            //  in your code, be sure that you know the exit code convention used by the application process."
            //  - https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.process.exitcode?view=netframework-4.8

            int guidProcessExitCode = guidProcess.ExitCode;
            WriteLine("Exit code:");
            WriteLine(guidProcessExitCode);
        }
    }
}

