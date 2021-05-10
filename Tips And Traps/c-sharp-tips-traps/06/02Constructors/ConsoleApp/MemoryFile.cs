using System.IO;

namespace ConsoleApp
{
    public class MemoryFile
    {
        public byte[] Bytes {get;}

        public MemoryFile(string path)
        {
            Bytes = File.ReadAllBytes(path); 
            
            // validation / error checking code omitted
        }

        public void SetFirstByte(byte b)
        {
            Bytes[0] = b;
        }
    }
}
