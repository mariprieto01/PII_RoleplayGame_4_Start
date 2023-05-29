using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Personaje Gigante
    /// </summary>
    public class Giant : Character
    {
        public Giant(string name)
            : base(name)
        {
            this.Health = 200;
        }
    }
}