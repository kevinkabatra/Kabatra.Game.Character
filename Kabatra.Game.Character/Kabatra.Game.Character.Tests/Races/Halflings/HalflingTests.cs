namespace Kabatra.Game.Character.Tests.Races.Halflings
{
    using Kabatra.Game.Character.Abilities;
    using Kabatra.Game.Character.Languages;
    using Kabatra.Game.Character.Races.Halflings;
    using Kabatra.Game.Character.Sizes;
    using Kabatra.Game.Character.Tests.Races.Data.Halflings;

    public class HalflingTests : RaceTests<Halfling, GenericHalfling>
    {
        public override float ExpectedSpeedInFeet { get => 25f; }
        public override SizeCategory ExpectedSizeCategory { get => SizeCategory.Small; }

        public override List<Language> ExpectedLanguages
        {
            get => new()
            {
                Language.Common,
                Language.Halfling
            };
        }

        public override List<AbilityScoreIncrease> ExpectedAbilityScoreIncrease
        {
            get => new()
            {
                new(Ability.Dexterity, 2),
            };
        }
    }
}
