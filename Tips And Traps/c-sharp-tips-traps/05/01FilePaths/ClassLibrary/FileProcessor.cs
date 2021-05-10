using System;
using System.IO;

namespace ClassLibrary
{
    public class FileProcessor
    {
        public void Process()
        {
            string inputFilePath = GetInputFilePath();

            // Perform some file processing

            string uploadUri = GetUploadUri();
            
            // upload file
        }

        public string GetInputFilePath()
        {
            var drive = @"C:\";
            var dir = @"temp\pspathdemo\";
            var file = "test.txt";


            //var fullPath = drive;

            //fullPath += dir;

            //if (!dir.EndsWith(@"\"))
            //{
            //    fullPath += @"\";
            //}

            //fullPath += file;

            //return fullPath;

            return Path.Combine(drive, dir, file);
        }

        public string GetUploadUri()
        {
            throw new NotImplementedException();
        }

        public void ZipDirectory(string dirToZip, string outputZipFilePath)
        {
            throw new NotImplementedException();
        }

        public void UnZip(string zipFilePath, string outputDir)
        {
            throw new NotImplementedException();
        }

        public void AddToZip(string zipFilePath, string extraFilePath)
        {
            throw new NotImplementedException();
        }

        public void RemoveFromZip(string zipFilePath, string fileToRemove)
        {
            throw new NotImplementedException();
        }

        public byte[] Compress(byte[] originalBytes)
        {
            throw new NotImplementedException();
        }

        public byte[] Decompress(byte[] compressedBytes)
        {
            throw new NotImplementedException();
        }
    }
}
