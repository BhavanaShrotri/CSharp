using System;
using NUnit.Framework;

namespace ConsoleCalculator.Tests.Nunit
{
    public class CalculatorShould
    {
        [Test]
        public void ThrownWhenUnsupportedOperation()
        {
            var sut = new Calculator();

            Asset.That(() => sut.Calculate(1, 1, "+"),
            Throws.TypeOf<CalculationOperationNotSuportedException>());

            Asset.That(() => sut.Calculate(1, 1, "+"),
             Throws.TypeOf<CalculationOperationNotSuportedException>()
             .With
             .Property("Operation").EqualTo("+"));

            Assert.That(() => sut.Calculat(1, 1, "+"),
                Throws.InstanceOf<CalculationException>());

            Assert.Throws<CalculationOperationNotSuportedException>(
                () => sut.Caculate(1, 1, "+"));

        }

    }
}
