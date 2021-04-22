using System;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {



            //var player = new PlayerCharacter();
            //player.Name = "Bhavana";
            //player.DaysSinceLastLogin = 23;

            //PlayerDisplayer.Write(player);


            PlayerCharacter?[] players =
            {
                new PlayerCharacter("Bhavana"),
                new PlayerCharacter( "Rachana"),
                new PlayerCharacter(null), 
                null
            };


            PlayerDisplayer.Write(players[0]);
            PlayerDisplayer.Write(players[1]);
            PlayerDisplayer.Write(players[2]);
            PlayerDisplayer.Write(players[3]);

            //Null conditional operator for array
            //PlayerCharacter[] player = null;

            //string p1 = player?[0]?.Name;
            //string p2 = player?[1]?.Name;
            //string p3 = player?[3]?.Name;

            Console.ReadKey();
        }
    }
}
