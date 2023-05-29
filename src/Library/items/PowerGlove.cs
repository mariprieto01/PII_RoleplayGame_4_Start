using System;
using System.Collections.Generic;

namespace RoleplayGame.Items
{
    public class PowerGlove : IAttackItem
    {
        public List<Gem> gems;
        public int AttackPower
        {
            get
            {
                int totalAttackPower = 0;
                foreach (var gem in gems)
                {
                    totalAttackPower += gem.AttackPower;
                }
                return totalAttackPower;
            }
        }
        public PowerGlove()
        {
            gems = new List<Gem>
            {
                new Gem(30),
                new Gem(15),
                new Gem(10)
            };
        }

        public void AddGem(Gem gem)
        {
            gems.Add(gem);
        }

        public override string ToString()
        {
            return "PowerGlove";
        }
    }
}