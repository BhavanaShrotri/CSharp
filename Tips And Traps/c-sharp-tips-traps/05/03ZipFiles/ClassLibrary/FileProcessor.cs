using System;
using System.IO;
using System.IO.Compression;

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
            //Uri uploadUri = new Uri("http://dontcodetired.com");
            Uri uploadUri = new Uri("http://dontcodetired.com/blog");

            return uploadUri.ToString();
        }

        public void ZipDirectory(string dirToZip, string outputZipFilePath)
        {
            ZipFile.CreateFromDirectory(dirToZip, 
                                        outputZipFilePath,
                                        CompressionLevel.Fastest,
                                        true);
        }

        public void UnZip(string zipFilePath, string outputDir)
        {
            ZipFile.ExtractToDirectory(zipFilePath, outputDir);
        }

        public void AddToZip(string zipFilePath, string extraFilePath)
        {
            using (ZipArchive zip = ZipFile.Open(zipFilePath, ZipArchiveMode.Update))
            {
                zip.CreateEntryFromFile(extraFilePath, Path.GetFileName(extraFilePath));
            }
        }

        public void RemoveFromZip(string zipFilePath, string fileToRemove)
        {
            using (ZipArchive zip = ZipFile.Open(zipFilePath, ZipArchiveMode.Update))
            {
                var f1 = zip.GetEntry(fileToRemove);
                f1.Delete();
            }
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
