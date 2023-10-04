namespace Kabatra.Game.Character.Abilities
{
    /// <summary>
    ///     Every race increases one or more of a character’s ability scores.
    /// </summary>
    /// <remarks>System Reference Document Page 3</remarks>
    public class AbilityScoreIncrease
    {
        public Ability Ability;
        public int Increase;

        public AbilityScoreIncrease(Ability ability, int increase)
        {
            Ability = ability;
            Increase = increase;
        }
    }
}
