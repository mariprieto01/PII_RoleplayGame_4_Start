namespace RoleplayGame.Characters
{
    /// <summary>
    /// Tipos de personajes
    /// </summary>
    public enum CharacterType
    {
        Elf = 1,
        Wizard = 2,
        Dwarf = 3,
        Knight = 4,
        Giant = 5,
        Archer = 6,
        Minotaur = 7,
    }

    /// <summary>
    /// Crea objetos de tipo Personaje
    /// </summary>
    public class CharacterFactory
    {
        /// <summary>
        /// Crea un personaje dado un tipo de personaje y un nombre
        /// </summary>
        public static Character GetCharacter(CharacterType type, string name)
        {
            switch (type)
            {
                case CharacterType.Elf: return new Elf(name);
                case CharacterType.Wizard: return new Wizard(name);
                case CharacterType.Dwarf: return new Dwarf(name);
                case CharacterType.Knight: return new Knight(name);
                case CharacterType.Giant: return new Giant(name);
                case CharacterType.Archer: return new Archer(name);
                case CharacterType.Minotaur: return new Minotaur(name);

                default: throw new System.Exception($"Invalid character {type}");
            }
        }
    }
}