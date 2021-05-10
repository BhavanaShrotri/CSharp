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

        public void SetFirstByte(byte @byte)
        {
            Bytes[0] = @byte;
        }

        //public byte this[int i]
        //{
        //    get
        //    {
        //        return Bytes[i];
        //    }
        //    set
        //    {
        //        Bytes[i] = value;
        //    }
        //}

        // C# >=7.0 expression-bodied member support for indexers
        public byte this[int i]
        {
            get => Bytes[i];
            set => Bytes[i] = value;
        }
    }
}
