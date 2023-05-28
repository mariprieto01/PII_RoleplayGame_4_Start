using System;
using System.Collections.Generic;

namespace RoleplayGame.Items
{
    public class Spear : IAttackItem
    {
        public int AttackPower
        {
            get
            {
                return 70;
            }
        }

        public override string ToString()
        {
            return "Spear";
        }
    }
}