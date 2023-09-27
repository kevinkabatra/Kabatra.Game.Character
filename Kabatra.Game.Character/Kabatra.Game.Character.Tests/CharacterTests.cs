namespace Kabatra.Game.Character.Tests
{
    public class CharacterTests
    {
        [Fact]
        public void CanCreateCharacter()
        {
            var character = new Character();
            Assert.NotNull(character);
        }
    }
}
