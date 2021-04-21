using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {
            if(string.IsNullOrWhiteSpace(player.Name))
            {
                Console.WriteLine("Player Name is Null or all WhiteSpaces");
            }
            else
            {
                Console.WriteLine(player.Name);
            }


            // Null-Coalescing operator for null checking 
             int days = player.DaysSinceLastLogin ??  -1;

            // Conditional operator for null checking 
            // int days = player.DaysSinceLastLogin.HasValue ? player.DaysSinceLastLogin.Value : -1;


            // int days = player.DaysSincelastLogin.GetValueOrDefault(-1);

            Console.WriteLine($"{days} days since last login");


            //if(player.DaysSincelastLogin.HasValue)
            //{
            //    Console.WriteLine(player.DaysSincelastLogin.Value);
            //}
            //else
            //{
            //    Console.WriteLine("No value for DaysSinceLastLogin");
            //}

            if (player.DateOfBirth == null)
            {
                Console.WriteLine("No date of birth specified");
            }
            else
            {
                Console.WriteLine(player.DateOfBirth);
            }

            if(player.IsNoob == null)
            {
                Console.WriteLine("Player newbie status is unknown.");
            }
            else if (player.IsNoob == true)
            {
                Console.WriteLine("Player is a newbie.");
            }
            else 
            {
                Console.WriteLine("Player is experienced.");
            }
        }
    }
}
