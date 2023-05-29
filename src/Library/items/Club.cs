using System;

namespace RoleplayGame.Items
{
    public class Club : IAttackItem
    {
    public int AttackPower
    { 
        get 
        {
            return 85;
        }
    }

        public override string ToString()
        {
            return "Club";
        }
    }
}