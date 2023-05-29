using System;

namespace RoleplayGame.Items
{
    public class Helmet : IDefenseItem
    {
        public int DefensePower
        { 
            get 
            {
                return 20;
            }
        }

        public override string ToString()
        {
            return "Helmet";
        }
    }
}
