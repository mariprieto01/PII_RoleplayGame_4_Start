using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Personaje Minotauro
    /// </summary>
    public class Minotaur : Character
    {
        public Minotaur(string name)
            : base(name)
        {
            this.Health = 100;
        }
    }
}