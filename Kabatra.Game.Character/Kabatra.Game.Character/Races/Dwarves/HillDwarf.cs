namespace Kabatra.Game.Character.Races.Dwarves
{
    using Kabatra.Game.Character.Abilities;
    using Kabatra.Game.Character.Alignments;

    /// <summary>
    /// <para>
    ///     As a hill dwarf, you have keen senses, deep intuition, and remarkable resilience.
    /// </para>
    /// <para>
    /// 1. Ability Score Increase. Your Wisdom score increases by 1.
    /// </para>
    /// <para>
    /// 2. Dwarven Toughness. Your hit point maximum increases by 1, and it increases by 1 every time you gain a level.
    /// </para>
    /// </summary>
    /// <remarks>System Reference Document Page 4</remarks>
    public class HillDwarf : Dwarf
    {
        protected new readonly static IEnumerable<AbilityScoreIncrease> BaseAbilityScoreIncrease = new List<AbilityScoreIncrease>() {
            new(Ability.Constitution, 2),
            new(Ability.Wisdom, 1),
        };
        protected new readonly static string BaseRaceDisplayName = "Hill Dwarf";

        public HillDwarf(float age, Alignment alignment, float heightInFeet, float weightInPounds) :
            base(BaseAbilityScoreIncrease, BaseRaceDisplayName, age, alignment, heightInFeet, weightInPounds)
        {
        }
    }
}
