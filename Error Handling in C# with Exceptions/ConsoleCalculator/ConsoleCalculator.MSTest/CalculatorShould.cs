using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace ConsoleCalculator.MSTest
{
    [TestClass]
    public class CalculatorShould
    {
        [TestMethod]
        public void ThrowWhenUnsupportedOperation()
        {
            var systemundertest = new Calculator();
        }
    }
}
