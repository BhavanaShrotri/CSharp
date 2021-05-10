using ConsoleApp.Analog;
using DigitalClock = ConsoleApp.Digital.Clock;

namespace ConsoleApp
{
    public class Project
    {        
        public string Name { get; set; }

        public Clock TimeLeft { get; set; } // Analog
        public DigitalClock TimeElapsed { get; set; } // Digital

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