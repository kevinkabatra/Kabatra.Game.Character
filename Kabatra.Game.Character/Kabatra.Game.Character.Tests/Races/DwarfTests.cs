namespace Kabatra.Game.Character.Tests.Races
{
    using Kabatra.Game.Character.Languages;
    using Kabatra.Game.Character.Races;
    using Kabatra.Game.Character.Sizes;
    using Kabatra.Game.Character.Tests.Races.Data;

    public class DwarfTests
    {
        [Fact]
        public void CanCreateDwarf()
        {
            Dwarf genericDwarf = GenericDwarf.Get();
            
            float ExpectedSpeedInFeet = 25f;
            SizeCategory ExpectedSizeCategory = SizeCategory.Medium;
            List<Language> ExpectedLanguages = new List<Language>() {  Language.Common, Language.Dwarvish };


            Assert.NotNull(genericDwarf);
            Assert.Equal(GenericDwarf.ExpectedAge, genericDwarf.Age);
            Assert.Equal(GenericDwarf.ExpectedAlignment, genericDwarf.Alignment);
            Assert.Equal(GenericDwarf.ExpectedHeightInFeet, genericDwarf.HeightInFeet);
            Assert.Equal(GenericDwarf.ExpectedWeightInPounds, genericDwarf.WeightInPounds);
            Assert.Equal(ExpectedSpeedInFeet, genericDwarf.SpeedInFeet);
            Assert.Equal(ExpectedSizeCategory, genericDwarf.Size.SizeCategory);
            Assert.Equal(ExpectedLanguages, genericDwarf.Languages);
        }
    }
}
