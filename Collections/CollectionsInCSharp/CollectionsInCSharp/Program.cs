using System;

namespace CollectionsInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dayofweek = {"Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"};

            foreach(var day in dayofweek)
            {
                Console.WriteLine(day);
            }
        }
    }
}
