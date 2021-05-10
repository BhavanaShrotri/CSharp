using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp
{
    class Program
    {
        const string InputFileName = "logo.png";
        const string EncodedFileName = "logo.txt";
        const string DecodedFileName = "logo_decoded.png";

        static void Main(string[] args)
        {
            ConvertFileToBase64();
            ConvertFileFromBase64();

            ConvertIntToBinary();
            ConvertDateTimeToBinary();

            //ChangeTypeExample();
            //ChangeTypeExampleV2();
            ChangeTypeExampleV3();

            ConvertCharacterToNumber();

            WriteLine("Press enter to exit.");
            ReadLine();
        }


        private static void ConvertFileToBase64()
        {
            byte[] originalBytes = File.ReadAllBytes(InputFileName);

            WriteLine($"Original file size {originalBytes.Length} bytes");

            string base64String = Convert.ToBase64String(originalBytes);

            File.WriteAllText(EncodedFileName, base64String);

            var encodedFileInfo = new FileInfo(EncodedFileName);
            WriteLine($"Base64 encoded file size {encodedFileInfo.Length} bytes");
        }
        
        private static void ConvertFileFromBase64()
        {
            string base64String = File.ReadAllText(EncodedFileName);

            byte[] fileBytes = Convert.FromBase64String(base64String);

            File.WriteAllBytes(DecodedFileName, fileBytes);
        }
        
        private static void ConvertIntToBinary()
        {
            WriteLine();
            WriteLine();
            Write("Please enter your age: ");
            string input = ReadLine();

            int age = int.Parse(input); // validation omitted

            byte[] intBytes = BitConverter.GetBytes(age);

            WriteLine($"age {age} in bytes = '{string.Join(" ", intBytes)}'");
        }

        private static void ConvertDateTimeToBinary()
        {
            DateTime now = DateTime.Now;

            WriteLine();
            WriteLine();
            WriteLine($"Original now = {now}");

            //byte[] nowBytes = BitConverter.GetBytes(now);
            long nowbinary = now.ToBinary();

            byte[] nowBytes = BitConverter.GetBytes(nowbinary);

            WriteLine($"Now bytes = '{string.Join(" ", nowBytes)}'");

            long nowBinaryConvertedBack = BitConverter.ToInt64(nowBytes, 0);

            DateTime nowConvertedBack = DateTime.FromBinary(nowBinaryConvertedBack);

            WriteLine($"Now converted back = {nowConvertedBack}");
        }

        private static void ChangeTypeExample()
        {
            WriteLine();
            WriteLine();
            WriteLine("Please enter the type to convert to: (i)nt (d)ouble (l)ong");
            string requestedType = ReadLine();

            object value = 42;

            switch (requestedType)
            {
                case "i":
                    int i = (int)value;
                    WriteLine($"Converted value: {i}");
                    break;
                case "d":
                    double d = (double)value;
                    WriteLine($"Converted value: {d}");
                    break;
                case "l":
                    long l = (long)value;
                    WriteLine($"Converted value: {l}");
                    break;
                default:
                    throw new NotSupportedException();
            }
        }

        private static void ChangeTypeExampleV2()
        {
            WriteLine();
            WriteLine();
            WriteLine("Please enter the type to convert to: (i)nt (d)ouble (l)ong");
            string requestedType = ReadLine();

            object value = 42;

            Type targetType = null;

            switch (requestedType)
            {
                case "i":
                    targetType = typeof(int);
                    break;
                case "d":
                    targetType = typeof(double);
                    break;
                case "l":
                    targetType = typeof(long);
                    break;
                default:
                    throw new NotSupportedException();
            }

            object convertedValue = Convert.ChangeType(value, targetType);
            WriteLine($"Converted value: {convertedValue} is a {convertedValue.GetType()}");
        }

        private static void ChangeTypeExampleV3()
        {
            WriteLine();
            WriteLine();
            WriteLine("Please enter the type to convert to: (System.Int32) (System.Double) (System.Int64)");
            string requestedType = ReadLine();

            object value = 42;

            Type targetType = Type.GetType(requestedType, true);

            object convertedValue = Convert.ChangeType(value, targetType);
            WriteLine($"Converted value: {convertedValue} is a {convertedValue.GetType()}");
        }

        private static void ConvertCharacterToNumber()
        {

        }

    }
}
