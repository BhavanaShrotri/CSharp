using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    class PlayerCharacter
    {
        public string Name { get; set; }
        public int DaysSincelastLogin { get; set; }
        public DateTime DateOfBirth { get; set; }

        public PlayerCharacter()
        {
            //initialization of magic numbers
            DateOfBirth = DateTime.MinValue;
            DaysSincelastLogin = -1;
        }


    }
}
