namespace Kabatra.Game.Character.Races.Dwarves
{
    using Kabatra.Game.Character.Abilities;
    using Kabatra.Game.Character.Alignments;

    public class HillDwarf : Dwarf
    {
        protected new readonly static IEnumerable<AbilityScoreIncrease> DwarfBaseAbilityScoreIncrease = new List<AbilityScoreIncrease>() { 
            new(Ability.Constitution, 2),
            new(Ability.Wisdom, 1),
        };

        protected new readonly static string DwarfBaseRaceDisplayName = "Hill Dwarf";

        public HillDwarf(float age, Alignment alignment, float heightInFeet, float weightInPounds) : base(DwarfBaseAbilityScoreIncrease, DwarfBaseRaceDisplayName, age, alignment, heightInFeet, weightInPounds)
        {
        }
    }
}
