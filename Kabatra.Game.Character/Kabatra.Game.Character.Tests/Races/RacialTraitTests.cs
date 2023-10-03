namespace Kabatra.Game.Character.Tests.Races
{
    using Kabatra.Game.Character.Abilities;
    using Kabatra.Game.Character.Alignments;
    using Kabatra.Game.Character.Races;

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
            AbilityScoreIncrease ExpectedAbilityScoreIncrease = new(
                Ability.Strength,
                2
            );

            float ExpectedAge = 1.364F;
            float ExpectedHeightInFeet = 6f;
            float ExpectedWeightInPounds = 200f;
            
            RacialTraits racialTrait = new(
                ExpectedAbilityScoreIncrease,
                ExpectedAge,
                ExpectedAlignment,
                ExpectedHeightInFeet,
                ExpectedWeightInPounds
            );

            Assert.NotNull(racialTrait);
            Assert.Equal(ExpectedAbilityScoreIncrease, racialTrait.AbilityScoreIncrease);
            Assert.Equal(ExpectedAge, racialTrait.Age);
            Assert.Equal(ExpectedAlignment, racialTrait.Alignment);
            Assert.Equal(ExpectedHeightInFeet, racialTrait.HeightInFeet);
            Assert.Equal(ExpectedWeightInPounds, racialTrait.WeightInPounds);
        }
    }
}
