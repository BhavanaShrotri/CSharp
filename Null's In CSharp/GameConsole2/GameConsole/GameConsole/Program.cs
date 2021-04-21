using System;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter bhavana = new PlayerCharacter(new DiamondSkinDefence())
            {
                Name = "Bhavana"
            };

            PlayerCharacter sana = new PlayerCharacter(new IronBonesDefence())
            {
                Name = "Sana"
            };

            PlayerCharacter hanna = new PlayerCharacter(SpecialDefence.Null)
            {
                Name = "Hanna"
            };

            bhavana.Hit(10);
            sana.Hit(10);
            hanna.Hit(10);

            Console.ReadKey();
        }
    }
}
