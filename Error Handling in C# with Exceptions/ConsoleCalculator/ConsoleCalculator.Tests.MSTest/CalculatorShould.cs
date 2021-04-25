using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleCalculator.Tests.MSTest
{
    [TestClass]
    public class CalculatorShould
    {
        [TestMethod]
        public void ThrowWhensupportedOperation()
        {
            var SystemUnderTest = new Calculator();

            Assert.ThrowsException<CalculationOperationNotSupportedException>(
                () => SystemUnderTest.Calculate(1, 1, "+"));


            var ex= Assert.ThrowsException<CalculationOperationNotSupportedException>(
                () => SystemUnderTest.Calculate(1, 1, "+"));

            Assert.AreEqual("+", ex.Operation);

            
        }
    }
}
