using ClassLibrary.Enums;
using System.Collections.Generic;
using Xunit;

namespace ClassLibrary.Tests
{
    public class AdvancedStringProcessorV2Should
    {
        private AdvancedStringProcessorV2 sut = null;
        private List<string> inputStrings;

        public AdvancedStringProcessorV2Should()
        {
            sut = new AdvancedStringProcessorV2();
            inputStrings = new List<string> { "Hello", "Welcome", "Howdy" };
        }

        [Fact]
        public void ProcessNone()
        {
            var results = sut.Process(inputStrings, StringProcessingOptionsV2.None);

            Assert.Equal(3, results.Count);

            Assert.Equal("Hello", results[0]);
            Assert.Equal("Welcome", results[1]);
            Assert.Equal("Howdy", results[2]);
        }

        [Fact]
        public void ProcessAddLength()
        {
            var results = sut.Process(inputStrings, StringProcessingOptionsV2.AddLength);

            Assert.Equal(3, results.Count);

            Assert.Equal("5-Hello", results[0]);
            Assert.Equal("7-Welcome", results[1]);
            Assert.Equal("5-Howdy", results[2]);
        }

        [Fact]
        public void ProcessConvertToUppercase()
        {
            var results = sut.Process(inputStrings, 
                                      StringProcessingOptionsV2.ConvertToUppercase);

            Assert.Equal(3, results.Count);

            Assert.Equal("HELLO", results[0]);
            Assert.Equal("WELCOME", results[1]);
            Assert.Equal("HOWDY", results[2]);
        }

        [Fact]
        public void ProcessConvertToUppercaseAndAddLength()
        {
            var results = sut.Process(inputStrings, StringProcessingOptionsV2.All);           

            Assert.Equal(3, results.Count);

            Assert.Equal("5-HELLO", results[0]);
            Assert.Equal("7-WELCOME", results[1]);
            Assert.Equal("5-HOWDY", results[2]);
        }
    }
}