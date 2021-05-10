using Xunit;

namespace ConsoleApp.Tests
{
    public class DataModelShould
    {
        [Fact]
        public void HaveDefaultStatus()
        {
            var sut = new DataModel();

            Assert.Equal("New", sut.Status);
        }

        [Fact]
        public void ClearStatus()
        {
            var sut = new DataModel();

            sut.ClearStatus();

            Assert.Equal("", sut.Status);
        }
    }
}
