namespace Kabatra.Game.Character
{
    using Abilities;

    public class Character
    {
        public readonly AbilityScores AbilityScores;

        public Character()
        {
            AbilityScores = new AbilityScores();
        }
    }
}