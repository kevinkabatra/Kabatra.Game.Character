namespace Kabatra.Game.Character.Tests.Races
{
    using Kabatra.Game.Character.Abilities;
    using Kabatra.Game.Character.Alignments;
    using Kabatra.Game.Character.Languages;
    using Kabatra.Game.Character.Tests.Races.Data;

    public class RacialTraitTests
    {
        [Theory]
        [InlineData(Alignment.Unaligned)]
        [InlineData(Alignment.LawfulGood)]
        [InlineData(Alignment.NeutralGood)]
        [InlineData(Alignment.ChaoticGood)]
        [InlineData(Alignment.LawfulNeutral)]
        [InlineData(Alignment.Neutral)]
        [InlineData(Alignment.ChaoticNeutral)]
        [InlineData(Alignment.LawfulEvil)]
        [InlineData(Alignment.NeutralEvil)]
        [InlineData(Alignment.ChaoticEvil)]
        public void CanCreateRacialTraitsWithAnyAlignment(Alignment ExpectedAlignment)
        {
            List<AbilityScoreIncrease> ExpectedAbilityScoreIncrease = new() { new(Ability.Strength, 2) };

            float ExpectedAge = 1.364F;
            float ExpectedHeightInFeet = 6f;
            float ExpectedWeightInPounds = 200f;
            float ExpectedSpeedInFeet = 25f;
            List<Language> ExpectedLanguages = new()
            { 
                Language.Common
            };

            GenericRace racialTrait = new(
                ExpectedAbilityScoreIncrease,
                ExpectedAge,
                ExpectedAlignment,
                ExpectedHeightInFeet,
                ExpectedWeightInPounds,
                ExpectedSpeedInFeet,
                ExpectedLanguages
            );

            Assert.NotNull(racialTrait);
            Assert.Equal(ExpectedAbilityScoreIncrease, racialTrait.AbilityScoreIncrease);
            Assert.Equal(ExpectedAge, racialTrait.Age);
            Assert.Equal(ExpectedAlignment, racialTrait.Alignment);
            Assert.Equal(ExpectedHeightInFeet, racialTrait.HeightInFeet);
            Assert.Equal(ExpectedWeightInPounds, racialTrait.WeightInPounds);
            Assert.Equal(ExpectedSpeedInFeet, racialTrait.SpeedInFeet);
            Assert.Equal(ExpectedLanguages, racialTrait.Languages);
        }
    }
}
