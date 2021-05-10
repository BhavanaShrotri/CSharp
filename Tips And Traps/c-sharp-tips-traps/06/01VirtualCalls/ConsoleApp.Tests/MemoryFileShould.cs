using Xunit;

namespace ConsoleApp.Tests
{
    public class MemoryFileShould
    {
        [Fact]
        public void ReadFile()
        {
            MemoryFile file = new MemoryFile("testfile.txt");

            Assert.Equal(13, file.Bytes.Length);
        }


        [Fact]
        public void SetBytes()
        {
            MemoryFile file = new MemoryFile("testfile.txt");

            file.SetFirstByte(42);

            Assert.Equal(42, file.Bytes[0]);
        }

    }
}
