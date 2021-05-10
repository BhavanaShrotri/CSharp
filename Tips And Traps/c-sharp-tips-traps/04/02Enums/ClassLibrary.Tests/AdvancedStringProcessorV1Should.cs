using ClassLibrary.Enums;
using System.Collections.Generic;
using Xunit;

namespace ClassLibrary.Tests
{
    public class AdvancedStringProcessorV1Should
    {
        private AdvancedStringProcessorV1 sut = null;
        private List<string> inputStrings;

        public AdvancedStringProcessorV1Should()
        {
            sut = new AdvancedStringProcessorV1();
            inputStrings = new List<string> { "Hello", "Welcome", "Howdy" };
        }

        [Fact]
        public void ProcessNone()
        {
            var results = sut.Process(inputStrings, StringProcessingOptionsV1.None);

            Assert.Equal(3, results.Count);

            Assert.Equal("Hello", results[0]);
            Assert.Equal("Welcome", results[1]);
            Assert.Equal("Howdy", results[2]);
        }

        [Fact]
        public void ProcessAddLength()
        {
            var results = sut.Process(inputStrings, StringProcessingOptionsV1.AddLength);

            Assert.Equal(3, results.Count);

            Assert.Equal("5-Hello", results[0]);
            Assert.Equal("7-Welcome", results[1]);
            Assert.Equal("5-Howdy", results[2]);
        }

        [Fact]
        public void ProcessConvertToUppercase()
        {
            var results = sut.Process(inputStrings,
                                      StringProcessingOptionsV1.ConvertToUppercase);

            Assert.Equal(3, results.Count);

            Assert.Equal("HELLO", results[0]);
            Assert.Equal("WELCOME", results[1]);
            Assert.Equal("HOWDY", results[2]);
        }
    }
}
