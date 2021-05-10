namespace ConsoleApp
{
    class Person
    {
        public string Name { get; }
        public int Age { get; }
        public string Gender { get; }

        private const string DefaultGender = "default";

        public Person(string name)
        {
            Name = name;
            Age = -1;
            Gender = DefaultGender;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Gender = DefaultGender;
        }

        public Person(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
