//ELEMENTO COMPUESTO
using System;
using System.Collections.Generic;
namespace RoleplayGame.Items
{
    public class MagicStick : IAttackItem
    {
        public Stick stick = new Stick();
        public Magic magic = new Magic();

        public int AttackPower
        {
            get
            {
                return this.stick.AttackPower + this.magic.AttackPower;
            }
        }

        public override string ToString()
        {
            return "BastonMagico";
        }
    }
}