using System;
using System.Collections.Generic;

namespace RoleplayGame.Items
{
    public class Shield : IDefenseItem
    {
        public int DefensePower
        {
            get
            {
                return 80;
            }
        }

        public override string ToString()
        {
            return "Shield";
        }
    }
}