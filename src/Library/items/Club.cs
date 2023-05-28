using System;

namespace RoleplayGame.Items
{
    public class Club : IAttackItem
    {
    public int AttackPower
    { 
        get 
        {
            return 80;
        }
    }

        public override string ToString()
        {
            return "Club";
        }
    }
}