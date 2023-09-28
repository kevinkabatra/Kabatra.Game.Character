namespace Kabatra.Game.Character.Tests.Abilities
{
    using Kabatra.Game.Character;

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
            character.AbilityScores.SetAbilityScores(
                expectedStrength,
                expectedDexterity,
                expectedConstitution,
                expectedIntelligence,
                expectedWisdom,
                expectedCharisma
            );

            Assert.Equal(expectedStrength, character.AbilityScores.Strength);
            Assert.Equal(expectedDexterity, character.AbilityScores.Dexterity);
            Assert.Equal(expectedConstitution, character.AbilityScores.Constitution);
            Assert.Equal(expectedIntelligence, character.AbilityScores.Intelligence);
            Assert.Equal(expectedWisdom, character.AbilityScores.Wisdom);
            Assert.Equal(expectedCharisma, character.AbilityScores.Charisma);
        }
    }
}