namespace Kabatra.Game.Character.Tests
{
    using Kabatra.Game.Character.Tests.Data;

    public class CharacterTests
    {
        [Fact]
        public void CanCreateCharacter()
        {
            GenericCharacter characterCreator = new();
            var character = characterCreator.Get();

            Assert.NotNull(character);
            Assert.Equal(characterCreator.ExpectedAbilityScores, character.AbilityScores);
            Assert.Equal(characterCreator.ExpectedRace, character.Race);
        }
    }
}
