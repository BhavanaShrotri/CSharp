using System;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new PlayerCharacter();

            player.Name = "Bhavana";
            player.DaysSincelastLogin = 42;
            
            PlayerDisplayer.Write(player);

            Console.ReadKey();
        }
    }
}
