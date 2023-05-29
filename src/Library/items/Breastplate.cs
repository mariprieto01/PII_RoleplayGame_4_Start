using System;

namespace RoleplayGame.Items
{
    public class Breastplate : IDefenseItem
    {
    public int DefensePower
    { 
        get 
        {
            return 12;
        }
    }

        public override string ToString()
        {
            return "Breastplate";
        }
    }
}