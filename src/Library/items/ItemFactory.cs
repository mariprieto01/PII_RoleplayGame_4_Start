using System;

namespace RoleplayGame.Items
{
    /// <summary>
    /// Tipos de elementos
    /// </summary>
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
        Gem = 9,
        Helmet = 10,
        MagicStick = 11,
        Spear = 12,
        Stick = 13,
    }

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
                case ItemType.Gem: return new Gem();
                case ItemType.Helmet: return new Helmet();
                case ItemType.MagicStick: return new MagicStick();
                case ItemType.Spear: return new Spear();
                case ItemType.Stick: return new Stick();


                default: return null;
            }
        }

        public static IItem GetRandomItem()
        {
            Random random = new Random();
            Array values = Enum.GetValues(typeof(ItemType));
            ItemType randomItemType = (ItemType)values.GetValue(random.Next(values.Length));
            return GetItem(randomItemType);
        }
    }
}