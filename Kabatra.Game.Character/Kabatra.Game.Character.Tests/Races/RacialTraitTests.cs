namespace Kabatra.Game.Character.Tests.Races
{
    using Kabatra.Game.Character.Abilities;
    using Kabatra.Game.Character.Alignments;
    using Kabatra.Game.Character.Races;
    using Kabatra.Game.Character.Sizes;

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
            Size ExpectedSize = Size.Medium;
            
            SpaceControlled ExpectedSpaceControlled = new(ConvertTo.SizeInFeet(ExpectedSize));

            RacialTraits racialTrait = new(
                ExpectedAbilityScoreIncrease,
                ExpectedAge,
                ExpectedAlignment,
                ExpectedSize
            );

            Assert.NotNull(racialTrait);
            Assert.Equal(ExpectedAbilityScoreIncrease, racialTrait.AbilityScoreIncrease);
            Assert.Equal(ExpectedAge, racialTrait.Age);
            Assert.Equal(ExpectedAlignment, racialTrait.Alignment);
            Assert.Equal(ExpectedSize, racialTrait.Size);
            Assert.Equal(ExpectedSpaceControlled, racialTrait.SpaceControlled);
        }

        [Theory]
        [InlineData(Size.Gargantuan)]
        [InlineData(Size.Huge)]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        [InlineData(Size.Tiny)]
        public void CanCreateRacialTraitsWithAnySize(Size ExpectedSize)
        {
            AbilityScoreIncrease ExpectedAbilityScoreIncrease = new(
                Ability.Strength,
                2
            );

            float ExpectedAge = 1.364F;

            Alignment ExpectedAlignment = Alignment.Unaligned;

            SpaceControlled ExpectedSpaceControlled = new(ConvertTo.SizeInFeet(ExpectedSize));

            RacialTraits racialTrait = new(
                ExpectedAbilityScoreIncrease,
                ExpectedAge,
                ExpectedAlignment,
                ExpectedSize
            );

            Assert.NotNull(racialTrait);
            Assert.Equal(ExpectedAbilityScoreIncrease, racialTrait.AbilityScoreIncrease);
            Assert.Equal(ExpectedAge, racialTrait.Age);
            Assert.Equal(ExpectedAlignment, racialTrait.Alignment);
            Assert.Equal(ExpectedSize, racialTrait.Size);
            Assert.Equal(ExpectedSpaceControlled, racialTrait.SpaceControlled);
        }
    }
}
