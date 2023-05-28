using System;
using System.Collections.Generic;

namespace RoleplayGame.Items
{
    public class Axe : IAttackItem
    {
        public int AttackPower
        {
            get
            {
                return 65;
            }
        }

        public override string ToString()
        {
            return "Axe";
        }
    }
}