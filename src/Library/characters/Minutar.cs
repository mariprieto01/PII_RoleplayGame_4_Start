using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Personaje Minotauro
    /// </summary>
    public class Minutar : Character
    {
        public Minutar(string name)
            : base(name)
        {
            this.Health = 100;
            this.AddItem(new Axe());
        }
    }
}