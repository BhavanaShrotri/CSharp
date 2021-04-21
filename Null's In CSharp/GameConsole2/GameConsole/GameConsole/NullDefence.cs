using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    class NullDefence : ISpecialDefence
    {
        public int CalculateDamageReduction(int totalDamage)
        {
            return 0; //no operation
        }
    }
}
