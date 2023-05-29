using System;
using System.Collections.Generic;
namespace RoleplayGame.Items
{
    /// <summary>
    /// Tipos de elementos
    /// </summary>

    public enum AttackItemType
    {
        Magic = 1,
        Axe = 2,
        Sword = 3,
        Club = 4,
        PowerGlove = 5,
        Gem = 6,
        MagicStick = 7,
        Spear = 8,
        Stick = 9,
    }

    public enum DefenseItemType
    {
        Robes = 1,
        Shield = 2,
        Breastplate = 3,
        Helmet = 4,
    }

    public enum ItemType
    {
        Magic = 1,
        Robes = 2,
        Axe = 3,
        Shield = 4,
        Sword = 5,
        Breastplate = 6,
        Club = 7,
        PowerGlove = 8,
        Helmet = 9,
        MagicStick = 10,
        Spear = 11,
        Stick = 12,

    };


    /// <summary>
    /// Creador de elementos. 
    /// </summary>
    public class ItemFactory
    {
        /// <summary>
        /// Permite crear elementos dado un tipo de elemento.
        /// </summary>
        /// <param name="type">El tipo de elemento</param>
        /// <returns>El elemento</returns>
        public static IItem GetItem(ItemType type)
        {
            switch (type)
            {
                case ItemType.Magic: return new Magic();
                case ItemType.Robes: return new Robes();
                case ItemType.Axe: return new Axe();
                case ItemType.Shield: return new Shield();
                case ItemType.Sword: return new Sword();
                case ItemType.Breastplate: return new Breastplate();
                case ItemType.Club: return new Club();
                case ItemType.PowerGlove: return new PowerGlove();
                case ItemType.Helmet: return new Helmet();
                case ItemType.MagicStick: return new MagicStick();
                case ItemType.Spear: return new Spear();
                case ItemType.Stick: return new Stick();


                default: return null;
            }
        }

        public static IAttackItem GetAttackItem(AttackItemType type)
        {
            switch (type)
            {
                case AttackItemType.Magic: return new Magic();
                case AttackItemType.Axe: return new Axe();
                case AttackItemType.Sword: return new Sword();
                case AttackItemType.Club: return new Club();
                case AttackItemType.PowerGlove: return new PowerGlove();
                case AttackItemType.MagicStick: return new MagicStick();
                case AttackItemType.Spear: return new Spear();
                case AttackItemType.Stick: return new Stick();

                default: return null;
            }
        }

        public static IDefenseItem GetDefenseItem(DefenseItemType type)
        {
            switch (type)
            {
                case DefenseItemType.Robes: return new Robes();
                case DefenseItemType.Shield: return new Shield();
                case DefenseItemType.Breastplate: return new Breastplate();
                case DefenseItemType.Helmet: return new Helmet();

                default: return null;
            }
        }

        public static IItem GetRandomItem(List<IItem> items)
        {
            if (items.Count >= 1)
            {
                if (items[0] is IDefenseItem)
                {
                    // delay
                    Random random = new Random();
                    Array values = Enum.GetValues(typeof(AttackItemType));
                    AttackItemType randomItemType = (AttackItemType)values.GetValue(random.Next(values.Length));
                    return GetAttackItem(randomItemType);
                }
                else
                {
                    Random random = new Random();
                    Array values = Enum.GetValues(typeof(DefenseItemType));
                    DefenseItemType randomItemType = (DefenseItemType)values.GetValue(random.Next(values.Length));
                    return GetDefenseItem(randomItemType);
                }
            }
            else
            {
                Random random = new Random();
                Array values = Enum.GetValues(typeof(ItemType));
                ItemType randomItemType = (ItemType)values.GetValue(random.Next(values.Length));
                return GetItem(randomItemType);
            }
        }
    }
}