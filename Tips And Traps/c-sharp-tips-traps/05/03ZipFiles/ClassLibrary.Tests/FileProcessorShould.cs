using System;
using System.IO;
using System.Text;
using Xunit;

namespace ClassLibrary.Tests
{
    public class FileProcessorShould
    {
        #region Path

        [Fact]
        public void GetInputFilePath()
        {
            FileProcessor sut = new FileProcessor();

            string path = sut.GetInputFilePath();

            Assert.Equal(@"C:\temp\pspathdemo\test.txt", path);
        }

        [Fact]
        public void UsefulPathMethods()
        {
            string path = @"c:\temp\pspathdemo\test.txt";

            path = Path.ChangeExtension(path, "bak");

            string dirName = Path.GetDirectoryName(path);

            string ext = Path.GetExtension(path);

            string file = Path.GetFileName(path);

            string fileNoExt = Path.GetFileNameWithoutExtension(path);

            bool hasExt = Path.HasExtension(path);
        }

        [Fact]
        public void UsefulGeneralMethods()
        {
            char[] invalidNameChars = Path.GetInvalidFileNameChars();

            string rndFileName = Path.GetRandomFileName();

            string rndTempFile = Path.GetTempFileName();

            string userTempPath = Path.GetTempPath();

            char platformSpecificDirSeparater = Path.DirectorySeparatorChar;
        }

        [Fact]
        public void PathCombinePeculiarities()
        {
            string result = Path.Combine(@"\data", @"c:\temp");

            result = Path.Combine(@"c:\temp", @"\data");

            result = Path.Combine(@"c:\temp", @"data");

            result = Path.Combine(@"c:\temp", 
                                  @"\data".TrimStart(Path.DirectorySeparatorChar));


            // using ".." to refer to parent dir
            result = Path.Combine(@"c:\temp\data", @"..");

            result = Path.GetFullPath(result);                        
        }

        #endregion


        #region Uri

        [Fact]
        public void GetUploadUri()
        {
            FileProcessor sut = new FileProcessor();

            string uri = sut.GetUploadUri();

            //Assert.Equal("http://dontcodetired.com/", uri);
            Assert.Equal("http://dontcodetired.com/blog", uri);
        }
        
        [Fact]
        public void NonHttpUris()
        {
            Uri localFile = new Uri(@"c:\temp\somefile.bin");
            Uri uncLanFile = new Uri(@"\\somepc\shareddocs\somefile.txt");
        }
        
        [Fact]
        public void CreatingRelativeAndAbsolute()
        {
            Uri dct1 = new Uri("http://dontcodetired.com"); // assumes absolute
            Uri dct2 = new Uri("http://dontcodetired.com", UriKind.Absolute);

            Uri relativeUri = new Uri("/index.html", UriKind.Relative);

            Uri relativeOrAbsolute = new Uri("/blog/", UriKind.RelativeOrAbsolute);

            Uri baseUri = new Uri("http://dontcodetired.com");
            Uri fullUri = new Uri(baseUri, relativeUri);
        }

        [Fact]
        public void UriParts()
        {
            Uri dct = new Uri("http://dontcodetired.com:8080/blog/?tag=code#somefragment");

            string scheme = dct.Scheme;

            string authority = dct.Authority; // Host name + port number (if non default port)
            string authorityHost = dct.Host; // Domain name or IP address (no port)
            int port = dct.Port;

            string pathAndQuery = dct.PathAndQuery;
            string absolutePath = dct.AbsolutePath;
            string query = dct.Query;

            string fragment = dct.Fragment;
        }


        [Fact]
        public void ModifyingAUri()
        {
            Uri dct = new Uri("http://dontcodetired.com:8080/blog/?tag=code#somefragment");

            // dct.Fragment = "newfrag"; // read only
            // dct.Port = 9090; // read only

            UriBuilder builder = new UriBuilder(dct);
            builder.Port = 9090;
            builder.Fragment = "newfrag";

            Uri modifiedDct = builder.Uri;
            string modified = modifiedDct.ToString();
        }


        [Fact]
        public void SomeOtherUsefulThings()
        {
            Uri dct = new Uri("http://dontcodetired.com/blog/");
            bool isDefaultPort = dct.IsDefaultPort;
            bool isFile = dct.IsFile;
            bool isUnc = dct.IsUnc;

            Uri localFile = new Uri("file:///c:/temp/somefile.bin");
            string path = localFile.LocalPath;
            isFile = localFile.IsFile;
            isUnc = localFile.IsUnc;
        }

        #endregion


        #region zip files


        private const string inputDirectory = @"c:\psdata\somefiles";
        private const string outputZipFile = @"c:\psdata\somefiles1.zip";

        [Fact]
        public void ZipFiles()
        {
            File.Delete(outputZipFile);

            FileProcessor sut = new FileProcessor();

            sut.ZipDirectory(inputDirectory, outputZipFile);

            Assert.True(File.Exists(outputZipFile));
        }

        [Fact]
        public void UnzipFiles()
        {
            ZipFiles();

            string unzipDestinationDir = Path.Combine(inputDirectory, @"..\unzip");
            unzipDestinationDir = Path.GetFullPath(unzipDestinationDir);

            if (Directory.Exists(unzipDestinationDir))
            {
                Directory.Delete(unzipDestinationDir, true);
            }

            FileProcessor sut = new FileProcessor();

            sut.UnZip(outputZipFile, unzipDestinationDir);

            // Asserts omitted
        }

        [Fact]
        public void AddFile()
        {
            ZipFiles();

            FileProcessor sut = new FileProcessor();

            sut.AddToZip(outputZipFile, @"c:\psdata\AnExtraFile.txt");

            // Asserts omitted
        }

        [Fact]
        public void RemoveFile()
        {
            ZipFiles();

            FileProcessor sut = new FileProcessor();

            sut.RemoveFromZip(outputZipFile, @"somefiles\text1.txt");

            // Asserts omitted
        }

        #endregion


        #region in-memory compression
        [Fact]
        public void CompressDecompress()
        {
            const string originalString = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce dignissim vitae nulla a vehicula. Quisque ut diam suscipit, accumsan turpis ac, feugiat lorem. Nam malesuada consequat mi, vitae vulputate diam gravida quis. Aenean a neque aliquet, luctus quam vel, mattis massa. Pellentesque placerat nec sapien quis lacinia. Sed non dui vel sapien tempus laoreet ut vel ligula. Donec mattis semper erat, porttitor facilisis tortor aliquet non.
                                         Proin vitae sollicitudin lorem, fermentum convallis risus. Aliquam tellus risus, porta id interdum ac, tincidunt nec nisl. Nulla in blandit nulla, bibendum volutpat eros. Praesent tincidunt risus nec venenatis vehicula. Praesent urna odio, tempor quis justo sed, semper auctor nisi. Nulla auctor blandit mauris sit amet varius. Cras suscipit fermentum libero ac dictum. Donec vulputate eros elementum tincidunt dapibus. Fusce eget elit quam. Vestibulum ut porta ante. Mauris quis sapien vitae nulla mattis dapibus. Curabitur cursus odio sit amet tellus iaculis faucibus. Nunc sed eleifend velit, eget tincidunt orci. Curabitur ornare felis id dolor porta interdum eget a nisi. Nam ut adipiscing dui. Duis eu sapien nisl.
                                         Maecenas vulputate cursus nulla et commodo. Morbi a rhoncus tellus. Ut hendrerit quis augue ultricies eleifend. Phasellus a feugiat urna, sed mattis lorem. Sed in rutrum sem. Praesent fermentum est erat. Etiam luctus velit a nulla semper interdum.
                                         Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Quisque magna neque, lacinia sit amet consectetur non, viverra vel ligula. Phasellus accumsan quis metus accumsan aliquam. Nam posuere lorem ligula, eu mattis enim mollis non. In hac habitasse platea dictumst. Integer tristique malesuada urna at fermentum. In eget pretium massa. Donec magna nisl, suscipit ut viverra a, vehicula eu nulla. In auctor lobortis aliquam. Vestibulum adipiscing est in mi tristique, nec aliquet elit vulputate. Etiam sollicitudin malesuada semper.
                                         Sed ornare, enim ut luctus cursus, mauris ligula semper libero, sed suscipit nisi lectus quis mi. Suspendisse et auctor odio. Proin vestibulum molestie ligula, ut dapibus quam euismod id. Donec consequat purus nec tellus vulputate sagittis. Nunc eu justo in elit commodo tincidunt sit amet eu erat. Vestibulum sed lacinia magna. Duis faucibus scelerisque sapien, non vulputate augue dignissim condimentum. Fusce gravida elementum cursus. Maecenas imperdiet, nulla sagittis bibendum aliquam, velit risus pharetra erat, vel adipiscing neque magna at erat";

            byte[] originalBytes = Encoding.ASCII.GetBytes(originalString);

            FileProcessor sut = new FileProcessor();

            // Compress
            byte[] compressedBytes = sut.Compress(originalBytes);

            int originalSize = originalBytes.Length;
            int compressedSize = compressedBytes.Length;
            int sizeDifference = originalSize - compressedSize;


            // Decompress
            byte[] decompressedBytes = sut.Decompress(compressedBytes);
            string decompressedString = Encoding.ASCII.GetString(decompressedBytes);

            Assert.Equal(originalBytes, decompressedBytes);
            Assert.Equal(originalString, decompressedString);
        }


        #endregion
    }
}
