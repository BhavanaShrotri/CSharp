using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileProcessor2
{
    class Processor
    {
        public List<Person> Process(string nameFilePath, string ageFilePath)
        {
            string[] names = LoadFileContents(nameFilePath);
            string[] ages = LoadFileContents(ageFilePath);

            return names.Zip(ages, 
                (name, age) => new Person {Name = name, Age = int.Parse(age)}).ToList();
        }

        private string[] LoadFileContents(string filePath)
        {
            try
            {
                return File.ReadAllLines(filePath);
            }
            catch (Exception ex)
            {
               Console.WriteLine(ex);
               throw ex;
            }            
        }
    }
}
