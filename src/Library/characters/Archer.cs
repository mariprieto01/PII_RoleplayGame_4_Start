using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Personaje Arquero
    /// </summary>
    public class Archer : Character
    {
        public Archer(string name)
            : base(name)
        {
            this.Health = 80;
        }
    }
}