namespace Kabatra.Game.Character
{
    using Abilities;
    using Kabatra.Game.Character.Races;

    /// <summary>
    ///     Playable or non-playable character.
    /// </summary>
    public class Character
    {
        public AbilityScores AbilityScores { get; private set; }
        public IRace Race { get; private set; }

        public Character(
            AbilityScores abilityScores,
            IRace race
        )
        {
            AbilityScores = abilityScores;
            Race = race;
        }
    }
}