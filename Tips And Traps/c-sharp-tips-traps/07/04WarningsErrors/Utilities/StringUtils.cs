using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Utilities
{
    public static class StringUtils
    {
        public static List<string> ToUpperAndWithLength(List<string> stringsToProcess)
        {
            var results = new List<string>();

            foreach (var s in stringsToProcess)
            {
                int length = CalculateLength(s);
                string upper = ConvertToUpper(s);                

                results.Add($"{length}-{upper}");
            }

            return results;
        }
        
        private static int CalculateLength(string s)
        {
            return s.Length;
        }

        internal static string ConvertToUpper(string s)
        {
            return s.ToUpperInvariant();
        }
    }
}
