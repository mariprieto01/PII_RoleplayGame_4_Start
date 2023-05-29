using System;
using System.Collections.Generic;

namespace RoleplayGame.Items
{
    public class Gem : IAttackItem
    {
        public int AttackPower { get; }
        public Gem(int attackPower)
        {
            AttackPower = attackPower;
        }

        public override string ToString()
        {
            return "Gem";
        }
    }
}