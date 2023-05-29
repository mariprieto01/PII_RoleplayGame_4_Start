using System;
using System.Collections.Generic;

namespace RoleplayGame.Items
{
    public class PowerGlove : IAttackItem
    {
        public int attackPower;
        public int AttackPower
        {
            get
            {
                return attackPower;
            }
        }
        public PowerGlove()
        {
            attackPower = 60;
        }
        public void AddGem(Gem gem)
        {
            attackPower += gem.AttackPower;
        }

        public override string ToString()
        {
            return "PowerGlove";
        }
    }
}