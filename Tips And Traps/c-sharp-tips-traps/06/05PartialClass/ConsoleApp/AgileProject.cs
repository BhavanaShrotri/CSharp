namespace ConsoleApp
{
    public class AgileProject : Project
    {
        protected int Length { get; set; }
        public AgileProject()
        {
            Name = "New Agile Project (unnamed)";
        }
        protected override void Initialize()
        {
            Length = Name.Length;
        }
    }

}