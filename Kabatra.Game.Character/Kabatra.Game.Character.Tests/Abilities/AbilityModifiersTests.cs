﻿namespace Kabatra.Game.Character.Tests.Abilities
{
    using Kabatra.Game.Character.Tests.Data;

    public class AbilityModifiersTests
    {
        [Theory]
        [InlineData(0, -5)]
        [InlineData(1, -5)]
        [InlineData(2, -4)]
        [InlineData(3, -4)]
        [InlineData(4, -3)]
        [InlineData(5, -3)]
        [InlineData(6, -2)]
        [InlineData(7, -2)]
        [InlineData(8, -1)]
        [InlineData(9, -1)]
        [InlineData(10, 0)]
        [InlineData(11, 0)]
        [InlineData(12, 1)]
        [InlineData(13, 1)]
        [InlineData(14, 2)]
        [InlineData(15, 2)]
        [InlineData(16, 3)]
        [InlineData(17, 3)]
        [InlineData(18, 4)]
        [InlineData(19, 4)]
        [InlineData(20, 5)]
        [InlineData(21, 5)]
        [InlineData(22, 6)]
        [InlineData(23, 6)]
        [InlineData(24, 7)]
        [InlineData(25, 7)]
        [InlineData(26, 8)]
        [InlineData(27, 8)]
        [InlineData(28, 9)]
        [InlineData(29, 9)]
        [InlineData(30, 10)]
        [InlineData(31, 10)]
        public void CanGetAbilityModifier(int abilityScore, int expectedAbilityModifier)
        {
            GenericCharacter characterCreator = new();
            var character = characterCreator.Get();
            character.AbilityScores.SetAbilityScores(
                abilityScore,
                abilityScore,
                abilityScore,
                abilityScore,
                abilityScore,
                abilityScore
            );

            Assert.Equal(expectedAbilityModifier, character.AbilityScores.GetStrengthModifier());
            Assert.Equal(expectedAbilityModifier, character.AbilityScores.GetDexterityModifier());
            Assert.Equal(expectedAbilityModifier, character.AbilityScores.GetConstitutionModifier());
            Assert.Equal(expectedAbilityModifier, character.AbilityScores.GetIntelligenceModifier());
            Assert.Equal(expectedAbilityModifier, character.AbilityScores.GetWisdomModifier());
            Assert.Equal(expectedAbilityModifier, character.AbilityScores.GetCharismaModifier());
        }
    }
}
