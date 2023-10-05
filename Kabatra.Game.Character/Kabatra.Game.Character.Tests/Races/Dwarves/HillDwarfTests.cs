namespace Kabatra.Game.Character.Tests.Races.Dwarves
{
    using Kabatra.Game.Character.Abilities;
    using Kabatra.Game.Character.Languages;
    using Kabatra.Game.Character.Races.Dwarves;
    using Kabatra.Game.Character.Sizes;
    using Kabatra.Game.Character.Tests.Races.Data.Dwarves;

    public class HillDwarfTests
    {
        [Fact]
        public void CanCreateHillDwarf()
        {
            Dwarf genericDwarf = GenericHillDwarf.Get();

            float ExpectedSpeedInFeet = 25f;
            SizeCategory ExpectedSizeCategory = SizeCategory.Medium;
            List<Language> ExpectedLanguages = new() { Language.Common, Language.Dwarvish };
            List<AbilityScoreIncrease> ExpectedAbilityScoreIncrease = new() {
                new(Ability.Constitution, 2),
                new(Ability.Wisdom, 1),
            };
            string ExpectedRaceDisplayName = "Hill Dwarf";

            Assert.NotNull(genericDwarf);
            Assert.Equal(GenericDwarf.ExpectedAge, genericDwarf.Age);
            Assert.Equal(GenericDwarf.ExpectedAlignment, genericDwarf.Alignment);
            Assert.Equal(GenericDwarf.ExpectedHeightInFeet, genericDwarf.HeightInFeet);
            Assert.Equal(GenericDwarf.ExpectedWeightInPounds, genericDwarf.WeightInPounds);
            Assert.Equal(ExpectedSpeedInFeet, genericDwarf.SpeedInFeet);
            Assert.Equal(ExpectedSizeCategory, genericDwarf.Size.SizeCategory);
            Assert.Equal(ExpectedLanguages, genericDwarf.Languages);
            Assert.Equal(ExpectedAbilityScoreIncrease, genericDwarf.AbilityScoreIncrease);
            Assert.Equal(ExpectedRaceDisplayName, genericDwarf.RaceDisplayName);
        }
    }
}
