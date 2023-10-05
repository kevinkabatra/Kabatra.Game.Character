namespace Kabatra.Game.Character.Tests.Races.Elves
{
    using Kabatra.Game.Character.Abilities;
    using Kabatra.Game.Character.Languages;
    using Kabatra.Game.Character.Races.Elves;
    using Kabatra.Game.Character.Sizes;
    using Kabatra.Game.Character.Tests.Races.Data.Elves;

    public class ElfTests
    {
        [Fact]
        public void CanCreateElf()
        {
            Elf genericElf = GenericElf.Get();

            float ExpectedSpeedInFeet = 30f;
            SizeCategory ExpectedSizeCategory = SizeCategory.Medium;
            List<Language> ExpectedLanguages = new() { Language.Common, Language.Elvish };
            List<AbilityScoreIncrease> ExpectedAbilityScoreIncrease = new() {
                new(Ability.Dexterity, 2),
            };

            Assert.NotNull(genericElf);
            Assert.Equal(GenericElf.ExpectedAge, genericElf.Age);
            Assert.Equal(GenericElf.ExpectedAlignment, genericElf.Alignment);
            Assert.Equal(GenericElf.ExpectedHeightInFeet, genericElf.HeightInFeet);
            Assert.Equal(GenericElf.ExpectedWeightInPounds, genericElf.WeightInPounds);
            Assert.Equal(ExpectedSpeedInFeet, genericElf.SpeedInFeet);
            Assert.Equal(ExpectedSizeCategory, genericElf.Size.SizeCategory);
            Assert.Equal(ExpectedLanguages, genericElf.Languages);
            Assert.Equal(ExpectedAbilityScoreIncrease, genericElf.AbilityScoreIncrease);
            Assert.Equal(nameof(Elf), genericElf.RaceDisplayName);
        }
    }
}
