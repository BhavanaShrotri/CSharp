using System.Collections.Generic;

namespace ConsoleApp
{
    public class StringProcessor
    {
        public List<string> ToUpperAndWithLength(List<string> stringsToProcess)
        {
            var results = new List<string>();

            foreach (var s in stringsToProcess)
            {
                //var result = Process(s);

                //results.Add($"{result.Length}-{result.UppercaseVersion}");

                Process(s);
            }

            return results;

            void Process(string s)
            {
                results.Add($"{s.Length}-{s.ToUpperInvariant()}");
            }
        }

        //private (int Length, string UppercaseVersion) Process(string s)
        //{
        //    return (s.Length, s.ToUpperInvariant());
        //}
    }
}
