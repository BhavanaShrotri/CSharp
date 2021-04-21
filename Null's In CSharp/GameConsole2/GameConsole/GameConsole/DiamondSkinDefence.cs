using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    class DiamondSkinDefence : SpecialDefence
    {
        public override int CalculateDamageReduction(int totalDamage)
        {
            return 1;
        }
    }
}
