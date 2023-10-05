namespace Kabatra.Game.Character.Tests.Races.Elves
{
    using Kabatra.Game.Character.Abilities;
    using Kabatra.Game.Character.Languages;
    using Kabatra.Game.Character.Races.Elves;
    using Kabatra.Game.Character.Sizes;
    using Kabatra.Game.Character.Tests.Races.Data.Elves;

    public  class HighElfTests
    {
        [Fact]
        public void CanCreateHighElf()
        {
            HighElf genericElf = GenericHighElf.Get();

            float ExpectedSpeedInFeet = 30f;
            SizeCategory ExpectedSizeCategory = SizeCategory.Medium;
            List<Language> ExpectedLanguages = new() { Language.Common, Language.Elvish };
            List<AbilityScoreIncrease> ExpectedAbilityScoreIncrease = new() {
                new(Ability.Dexterity, 2),
                new(Ability.Intelligence, 1),
            };
            string ExpectedRaceDisplayName = "High Elf";

            Assert.NotNull(genericElf);
            Assert.Equal(GenericHighElf.ExpectedAge, genericElf.Age);
            Assert.Equal(GenericHighElf.ExpectedAlignment, genericElf.Alignment);
            Assert.Equal(GenericHighElf.ExpectedHeightInFeet, genericElf.HeightInFeet);
            Assert.Equal(GenericHighElf.ExpectedWeightInPounds, genericElf.WeightInPounds);
            Assert.Equal(ExpectedSpeedInFeet, genericElf.SpeedInFeet);
            Assert.Equal(ExpectedSizeCategory, genericElf.Size.SizeCategory);
            Assert.Equal(ExpectedLanguages, genericElf.Languages);
            Assert.Equal(ExpectedAbilityScoreIncrease, genericElf.AbilityScoreIncrease);
            Assert.Equal(ExpectedRaceDisplayName, genericElf.RaceDisplayName);
        }
    }
}
