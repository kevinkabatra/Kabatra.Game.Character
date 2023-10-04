namespace Kabatra.Game.Character.Tests.Races
{
    using Kabatra.Game.Character.Alignments;
    using Kabatra.Game.Character.Languages;
    using Kabatra.Game.Character.Races;
    using Kabatra.Game.Character.Sizes;

    public class DwarfTests
    {
        [Fact]
        public void CanCreateDwarf()
        {
            float ExpectedAge = 100F;
            Alignment ExpectedAlignment = Alignment.LawfulGood;
            float ExpectedHeightInFeet = 4.5f;
            float ExpectedWeightInPounds = 200f;
            float ExpectedSpeedInFeet = 25f;
            SizeCategory ExpectedSizeCategory = SizeCategory.Medium;
            List<Language> ExpectedLanguages = new List<Language>() {  Language.Common, Language.Dwarvish };

            Dwarf dwarf = new(ExpectedAge, ExpectedAlignment, ExpectedHeightInFeet, ExpectedWeightInPounds);

            Assert.NotNull(dwarf);
            Assert.Equal(ExpectedAge, dwarf.Age);
            Assert.Equal(ExpectedAlignment, dwarf.Alignment);
            Assert.Equal(ExpectedHeightInFeet, dwarf.HeightInFeet);
            Assert.Equal(ExpectedWeightInPounds, dwarf.WeightInPounds);
            Assert.Equal(ExpectedSpeedInFeet, dwarf.SpeedInFeet);
            Assert.Equal(ExpectedSizeCategory, dwarf.Size.SizeCategory);
            Assert.Equal(ExpectedLanguages, dwarf.Languages);
        }
    }
}
