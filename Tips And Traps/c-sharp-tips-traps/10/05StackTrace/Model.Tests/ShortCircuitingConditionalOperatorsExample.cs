using Xunit;

namespace Model.Tests
{
    public class ShortCircuitingConditionalOperatorsExample
    {

        [Fact]
        public void NonShortCircuit()
        {
            const string name = "Sarah";
            bool isValid = false;

            // Short-circuiting logical AND
            bool shouldContinue = isValid && name == "Sarah";
            shouldContinue = isValid && CheckName(name);

            // Non-short-circuiting logical AND
            shouldContinue = isValid & CheckName(name);

            isValid = true;
            // Short-circuiting logical OR
            shouldContinue = isValid || CheckName(name);

            // Non-short-circuiting logical OR
            shouldContinue = isValid | CheckName(name);



            // You should generally avoid writing code that relies on these kind of side-effects
            bool CheckName(string nameToCheck)
            {
                return nameToCheck == "Sarah";
            }
        }
    }
}