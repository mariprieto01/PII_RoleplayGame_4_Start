using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Personaje Caballero
    /// </summary>
    public class Knight : Character
    {
        public Knight(string name)
            : base(name)
        {
            this.Health = 100;
            this.AddItem(new Sword());
            this.AddItem(new Shield());
        }
    }
}