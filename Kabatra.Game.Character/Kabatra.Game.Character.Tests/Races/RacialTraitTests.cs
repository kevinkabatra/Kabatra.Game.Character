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
        public void CanCreateRacialTraits(
            Alignment alignment
        )
        {
            AbilityScoreIncrease ExpectedAbilityScoreIncrease = new(
                Ability.Strength,
                2
            );

            float ExpectedAge = 1.364F;

            RacialTraits racialTrait = new(
                ExpectedAbilityScoreIncrease,
                ExpectedAge,
                alignment
            );

            Assert.NotNull(racialTrait);
            Assert.Equal(ExpectedAbilityScoreIncrease, racialTrait.AbilityScoreIncrease);
            Assert.Equal(ExpectedAge, racialTrait.Age);
            Assert.Equal(alignment, racialTrait.Alignment);
        }
    }
}
