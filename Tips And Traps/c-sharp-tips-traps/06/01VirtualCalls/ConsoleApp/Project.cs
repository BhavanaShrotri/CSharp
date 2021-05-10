namespace ConsoleApp
{
    public class Project
    {        
        public string Name { get; set; }

        public Project()
        {
            Initialize();
        }

        protected virtual void Initialize()
        {
        }

        public override string ToString()
        {
            return Name;
        }
    }
}