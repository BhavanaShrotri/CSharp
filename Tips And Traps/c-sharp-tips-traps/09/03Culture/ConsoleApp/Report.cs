using System;
using System.Threading;
using static System.Console;

namespace ConsoleApp
{
    class Report
    {
        public string ReportName { get; private set; }

        public Report()
        {
            WriteLine("*********** Creating report (default ctor) *********** ");

            ReportName = "Default";

            // Simulate resource intensive object creation
            Thread.Sleep(10000);
        }

        public Report(string reportName)
        {
            WriteLine("*********** Creating report (reportName ctor) *********** ");

            ReportName = reportName;

            // Simulate resource intensive object creation
            Thread.Sleep(10000);
        }        

        public void Run()
        {
            WriteLine("The report is good...");
        }
    }
}
