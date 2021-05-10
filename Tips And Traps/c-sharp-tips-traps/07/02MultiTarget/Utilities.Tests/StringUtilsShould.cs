using System;
using System.Collections.Generic;
using Xunit;

namespace Utilities.Tests
{
    public class StringUtilsShould
    {
        [Fact]
        public void ConvertToUpperAndAddLength()
        {
            List<string> inputStrings = new List<string>
            {
                "Hello",
                "Welcome",
                "Howdy"
            };

            List<string> results = StringUtils.ToUpperAndWithLength(inputStrings);

            Assert.Equal(3, results.Count);

            Assert.Equal("5-HELLO", results[0]);
            Assert.Equal("7-WELCOME", results[1]);
            Assert.Equal("5-HOWDY", results[2]);
        }


        //[Fact]
        //public void ConvertToUpper()
        //{
        //    string inputString = "hello";

        //    string result = StringUtils.ConvertToUpper(inputString);
          
        //    Assert.Equal("HELLO", result);
        //}


    }
}
