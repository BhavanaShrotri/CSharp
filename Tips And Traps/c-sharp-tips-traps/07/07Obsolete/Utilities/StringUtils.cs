using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Utilities.Tests")]

//[assembly: InternalsVisibleTo("Utilities.Tests, PublicKey=002400000480000094" +
//                              "0000000602000000240000525341310004000" +
//                              "001000100bf8c25fcd44838d87e245ab35bf7" +
//                              "3ba2615707feea295709559b3de903fb95a93" +
//                              "3d2729967c3184a97d7b84c7547cd87e435b5" +
//                              "6bdf8621bcb62b59c00c88bd83aa62c4fcdd4" +
//                              "712da72eec2533dc00f8529c3a0bbb4103282" +
//                              "f0d894d5f34e9f0103c473dce9f4b457a5dee" +
//                              "fd8f920d8681ed6dfcb0a81e96bd9b176525a" +
//                              "26e0b3")]

namespace Utilities
{
    public static class StringUtils
    {
        [Obsolete("This will be removed in v2")]
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
