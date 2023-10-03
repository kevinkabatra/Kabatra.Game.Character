namespace Kabatra.Game.Character.Tests.Sizes
{
    using Kabatra.Game.Character.Sizes;

    public class CheckIsCharacterSqueezedTests
    {
        [Theory]
        [InlineData(0, SizeCategory.Fine)]
        [InlineData(0, SizeCategory.Diminiutive)]
        [InlineData(0, SizeCategory.Tiny)]
        [InlineData(0, SizeCategory.Small)]
        [InlineData(0, SizeCategory.Medium)]
        [InlineData(0, SizeCategory.Large)]
        [InlineData(0, SizeCategory.Huge)]
        [InlineData(0, SizeCategory.Gargantuan)]
        [InlineData(0, SizeCategory.Colossal)]

        [InlineData(.51, SizeCategory.Diminiutive)]
        [InlineData(.51, SizeCategory.Tiny)]
        [InlineData(.51, SizeCategory.Small)]
        [InlineData(.51, SizeCategory.Medium)]
        [InlineData(.51, SizeCategory.Large)]
        [InlineData(.51, SizeCategory.Huge)]
        [InlineData(.51, SizeCategory.Gargantuan)]
        [InlineData(.51, SizeCategory.Colossal)]
        
        [InlineData(1.01, SizeCategory.Tiny)]
        [InlineData(1.01, SizeCategory.Small)]
        [InlineData(1.01, SizeCategory.Medium)]
        [InlineData(1.01, SizeCategory.Large)]
        [InlineData(1.01, SizeCategory.Huge)]
        [InlineData(1.01, SizeCategory.Gargantuan)]
        [InlineData(1.01, SizeCategory.Colossal)]

        [InlineData(2.01, SizeCategory.Small)]
        [InlineData(2.01, SizeCategory.Medium)]
        [InlineData(2.01, SizeCategory.Large)]
        [InlineData(2.01, SizeCategory.Huge)]
        [InlineData(2.01, SizeCategory.Gargantuan)]
        [InlineData(2.01, SizeCategory.Colossal)]

        [InlineData(4.01, SizeCategory.Medium)]
        [InlineData(4.01, SizeCategory.Large)]
        [InlineData(4.01, SizeCategory.Huge)]
        [InlineData(4.01, SizeCategory.Gargantuan)]
        [InlineData(4.01, SizeCategory.Colossal)]
        
        [InlineData(8.01, SizeCategory.Large)]
        [InlineData(8.01, SizeCategory.Huge)]
        [InlineData(8.01, SizeCategory.Gargantuan)]
        [InlineData(8.01, SizeCategory.Colossal)]

        [InlineData(16.01, SizeCategory.Huge)]
        [InlineData(16.01, SizeCategory.Gargantuan)]
        [InlineData(16.01, SizeCategory.Colossal)]
        
        [InlineData(32.01, SizeCategory.Gargantuan)]
        [InlineData(32.01, SizeCategory.Colossal)]
        
        [InlineData(64.01, SizeCategory.Colossal)]
        public void CharacterIsNotSqueezed(float characterHeight, SizeCategory spaceSize)
        {
            Size characterSize = new(characterHeight, 0);
            characterSize.CheckIsCharacterSqueezed(spaceSize);

            Assert.False(characterSize.IsCharacterSqueezed);
        }
        
        [Theory]
        [InlineData(.51, SizeCategory.Fine)]

        [InlineData(1.01, SizeCategory.Fine)]
        [InlineData(1.01, SizeCategory.Diminiutive)]

        [InlineData(2.01, SizeCategory.Fine)]
        [InlineData(2.01, SizeCategory.Diminiutive)]
        [InlineData(2.01, SizeCategory.Tiny)]

        [InlineData(4.01, SizeCategory.Fine)]
        [InlineData(4.01, SizeCategory.Diminiutive)]
        [InlineData(4.01, SizeCategory.Tiny)]
        [InlineData(4.01, SizeCategory.Small)]

        [InlineData(8.01, SizeCategory.Fine)]
        [InlineData(8.01, SizeCategory.Diminiutive)]
        [InlineData(8.01, SizeCategory.Tiny)]
        [InlineData(8.01, SizeCategory.Small)]
        [InlineData(8.01, SizeCategory.Medium)]

        [InlineData(16.01, SizeCategory.Fine)]
        [InlineData(16.01, SizeCategory.Diminiutive)]
        [InlineData(16.01, SizeCategory.Tiny)]
        [InlineData(16.01, SizeCategory.Small)]
        [InlineData(16.01, SizeCategory.Medium)]
        [InlineData(16.01, SizeCategory.Large)]

        [InlineData(32.01, SizeCategory.Fine)]
        [InlineData(32.01, SizeCategory.Diminiutive)]
        [InlineData(32.01, SizeCategory.Tiny)]
        [InlineData(32.01, SizeCategory.Small)]
        [InlineData(32.01, SizeCategory.Medium)]
        [InlineData(32.01, SizeCategory.Large)]
        [InlineData(32.01, SizeCategory.Huge)]

        [InlineData(64.01, SizeCategory.Fine)]
        [InlineData(64.01, SizeCategory.Diminiutive)]
        [InlineData(64.01, SizeCategory.Tiny)]
        [InlineData(64.01, SizeCategory.Small)]
        [InlineData(64.01, SizeCategory.Medium)]
        [InlineData(64.01, SizeCategory.Large)]
        [InlineData(64.01, SizeCategory.Huge)]
        [InlineData(64.01, SizeCategory.Gargantuan)]
        public void CharacterIsSqueezed(float characterHeight, SizeCategory spaceSize)
        {
            Size characterSize = new(characterHeight, 0);
            characterSize.CheckIsCharacterSqueezed(spaceSize);

            Assert.True(characterSize.IsCharacterSqueezed);
        }
    }
}
