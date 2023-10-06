namespace Kabatra.Game.Character.Tests.Races.Dwarves
{
    using Kabatra.Game.Character.Abilities;
    using Kabatra.Game.Character.Languages;
    using Kabatra.Game.Character.Races.Dwarves;
    using Kabatra.Game.Character.Sizes;
    using Kabatra.Game.Character.Tests.Races.Data.Dwarves;

    public class HillDwarfTests : RaceTests<HillDwarf, GenericHillDwarf>
    {
        public override float ExpectedSpeedInFeet { get => 25f; }
        public override SizeCategory ExpectedSizeCategory { get => SizeCategory.Medium; }

        public override List<Language> ExpectedLanguages
        {
            get => new()
            {
                Language.Common,
                Language.Dwarvish
            };
        }

        public override List<AbilityScoreIncrease> ExpectedAbilityScoreIncrease
        {
            get => new()
            {
                new(Ability.Constitution, 2),
                new(Ability.Wisdom, 1),
            };
        }

        public override string ExpectedRaceDisplayName { get => "Hill Dwarf"; }
    }
}
