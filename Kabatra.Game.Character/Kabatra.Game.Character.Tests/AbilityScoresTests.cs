namespace Kabatra.Game.Character.Tests
{
    public class AbilityScoresTests
    {
        [Fact]
        public void CanSetAbilityScores()
        {
            var expectedStrength = 1;
            var expectedDexterity = 2;
            var expectedConstitution = 3;
            var expectedIntelligence = 4;
            var expectedWisdom = 5;
            var expectedCharisma = 6;

            var character = new Character();
            character.SetAbilityScores(
                expectedStrength,
                expectedDexterity,
                expectedConstitution,
                expectedIntelligence,
                expectedWisdom,
                expectedCharisma
            );

            Assert.Equal(expectedStrength, character.Strength);
            Assert.Equal(expectedDexterity, character.Dexterity);
            Assert.Equal(expectedConstitution, character.Constitution);
            Assert.Equal(expectedIntelligence, character.Intelligence);
            Assert.Equal(expectedWisdom, character.Wisdom);
            Assert.Equal(expectedCharisma, character.Charisma);
        }

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
            var character = new Character();
            character.SetAbilityScores(
                abilityScore,
                abilityScore,
                abilityScore,
                abilityScore,
                abilityScore,
                abilityScore
            );

            Assert.Equal(expectedAbilityModifier, character.GetStrengthModifier());
            Assert.Equal(expectedAbilityModifier, character.GetDexterityModifier());
            Assert.Equal(expectedAbilityModifier, character.GetConstitutionModifier());
            Assert.Equal(expectedAbilityModifier, character.GetIntelligenceModifier());
            Assert.Equal(expectedAbilityModifier, character.GetWisdomModifier());
            Assert.Equal(expectedAbilityModifier, character.GetCharismaModifier());
        }
    }
}