using DateUtils;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var formatter = new DateFormatter();

            string formatedNow = formatter.Format(DateTime.Now);

            Console.WriteLine(formatedNow);
            Console.ReadLine();
        }
    }
}
