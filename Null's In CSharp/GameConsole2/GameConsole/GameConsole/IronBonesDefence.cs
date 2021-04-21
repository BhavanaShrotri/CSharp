using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    public class IronBonesDefence : ISpecialDefence
    {
        public int CalculateDamageReduction(int totalDamage)
        {
            return 5;
        }
    }
}
