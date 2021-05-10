using System;

namespace ConsoleApp
{
    class GreetingGenerator
    {
        public static string GreetingPrefix;

        static GreetingGenerator()
        {
            GreetingPrefix = "Hi";
            // throw new Exception("Simulated exception in static ctor");
        }

        public string Generate()
        {
            bool isAfternoon = DateTime.Now.Hour >= 12;

            if (isAfternoon)
            {
                return " and good afternoon";
            }

            return " and good morning";
        }
    }
}
