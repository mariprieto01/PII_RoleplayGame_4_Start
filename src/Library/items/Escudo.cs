using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoleplayGame.Items
{
    public class Escudo : IDefenseItem
    {
        public int DefensePower
        {
            get {

                return 80;
                
            }
        }
    }
}