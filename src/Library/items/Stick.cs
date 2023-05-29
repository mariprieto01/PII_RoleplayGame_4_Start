using System;

namespace RoleplayGame.Items
{
    public class Stick : IAttackItem
    {
        public int AttackPower
        {
            get
            {
                return 34;
            }
        }

        public override string ToString()
        {
            return "Stick";
        }
    }
}
