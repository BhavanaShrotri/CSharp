using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    public interface ISpecialDefence
    {
        int CalculateDamageReduction(int totalDamage);
    }
}
