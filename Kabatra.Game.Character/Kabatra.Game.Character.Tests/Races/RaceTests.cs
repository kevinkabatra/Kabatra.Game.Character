namespace Kabatra.Game.Character.Tests.Races
{
    using System.Collections.Generic;
    using Kabatra.Game.Character.Abilities;
    using Kabatra.Game.Character.Languages;
    using Kabatra.Game.Character.Races;
    using Kabatra.Game.Character.Sizes;
    using Kabatra.Game.Character.Tests.Races.Data;

    #pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public abstract class RaceTests<TRace, TGenericRace> 
        where TRace : IRace
        where TGenericRace : IGenericRaceCreator, new()
    {
        public virtual float ExpectedSpeedInFeet { get; }
        public virtual SizeCategory ExpectedSizeCategory { get; }
        public virtual List<Language> ExpectedLanguages { get; }
        public virtual List<AbilityScoreIncrease> ExpectedAbilityScoreIncrease { get; }
        public virtual string ExpectedRaceDisplayName { get => typeof(TRace).Name; }

        [Fact]
        public void CanCreateCharacterOfTypeRace()
        {
            TGenericRace ExpectedRaceCreator = new();
            TRace character = (TRace)ExpectedRaceCreator.Get();

            Assert.NotNull(character);
            Assert.Equal(ExpectedRaceCreator.ExpectedAge, character.Age);
            Assert.Equal(ExpectedRaceCreator.ExpectedAlignment, character.Alignment);
            Assert.Equal(ExpectedRaceCreator.ExpectedHeightInFeet, character.HeightInFeet);
            Assert.Equal(ExpectedRaceCreator.ExpectedWeightInPounds, character.WeightInPounds);
            Assert.Equal(ExpectedSpeedInFeet, character.SpeedInFeet);
            Assert.Equal(ExpectedSizeCategory, character.Size.SizeCategory);
            Assert.Equal(ExpectedLanguages, character.Languages);
            Assert.Equal(ExpectedAbilityScoreIncrease, character.AbilityScoreIncrease);
            Assert.Equal(ExpectedRaceDisplayName, character.RaceDisplayName);
        }
    }
}
