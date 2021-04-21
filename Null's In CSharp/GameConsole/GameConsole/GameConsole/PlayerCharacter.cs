using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    class PlayerCharacter
    {
        public string Name { get; set; }
        public Nullable<int> DaysSincelastLogin { get; set; }
        public Nullable<DateTime> DateOfBirth { get; set; }

        public PlayerCharacter()
        {
            //initialization of magic numbers
            DateOfBirth = null;
            DaysSincelastLogin = null;
        }


    }
}
