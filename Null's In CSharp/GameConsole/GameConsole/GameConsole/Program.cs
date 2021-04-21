using System;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {



            var player = new PlayerCharacter();
            player.Name = "Bhavana";
            player.DaysSinceLastLogin = 23;

            PlayerDisplayer.Write(player);


            //PlayerCharacter[] player = new PlayerCharacter[3]
            //{
            //    new PlayerCharacter{Name = "Bhavana"},
            //    new PlayerCharacter(),
            //    null
            //};

            //Null conditional operator for array 
            //PlayerCharacter[] player = null;

            //string p1 = player?[0]?.Name;
            //string p2 = player?[1]?.Name;
            //string p3 = player?[3]?.Name;

            Console.ReadKey();
        }
    }
}
