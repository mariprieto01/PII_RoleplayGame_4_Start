using System.Collections.Generic;
using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    public class Dwarf : Character
    {
        public Dwarf(string name)
            : base(name)
        {
            this.Health = 100;
        }
    }
}