namespace Kabatra.Game.Character.Tests.Races
{
    using Kabatra.Game.Character.Languages;
    using Kabatra.Game.Character.Races.Dwarves;
    using Kabatra.Game.Character.Sizes;
    using Kabatra.Game.Character.Tests.Races.Data;

    public class HillDwarfTests
    {
        [Fact]
        public void CanCreateHillDwarf()
        {
            Dwarf genericDwarf = GenericHillDwarf.Get();

            float ExpectedSpeedInFeet = 25f;
            SizeCategory ExpectedSizeCategory = SizeCategory.Medium;
            List<Language> ExpectedLanguages = new() { Language.Common, Language.Dwarvish };


            Assert.NotNull(genericDwarf);
            Assert.Equal(GenericHillDwarf.ExpectedAge, genericDwarf.Age);
            Assert.Equal(GenericHillDwarf.ExpectedAlignment, genericDwarf.Alignment);
            Assert.Equal(GenericHillDwarf.ExpectedHeightInFeet, genericDwarf.HeightInFeet);
            Assert.Equal(GenericHillDwarf.ExpectedWeightInPounds, genericDwarf.WeightInPounds);
            Assert.Equal(ExpectedSpeedInFeet, genericDwarf.SpeedInFeet);
            Assert.Equal(ExpectedSizeCategory, genericDwarf.Size.SizeCategory);
            Assert.Equal(ExpectedLanguages, genericDwarf.Languages);
        }
    }
}
