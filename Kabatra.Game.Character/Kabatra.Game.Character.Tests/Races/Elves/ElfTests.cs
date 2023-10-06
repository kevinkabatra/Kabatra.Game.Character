namespace Kabatra.Game.Character.Tests.Races.Elves
{
    using Kabatra.Game.Character.Abilities;
    using Kabatra.Game.Character.Languages;
    using Kabatra.Game.Character.Races.Elves;
    using Kabatra.Game.Character.Sizes;
    using Kabatra.Game.Character.Tests.Races.Data.Elves;

    public class ElfTests : RaceTests<Elf, GenericElf>
    {
        public override float ExpectedSpeedInFeet { get => 30f; }
        public override SizeCategory ExpectedSizeCategory { get => SizeCategory.Medium; }

        public override List<Language> ExpectedLanguages
        {
            get => new()
            {
                Language.Common,
                Language.Elvish
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
