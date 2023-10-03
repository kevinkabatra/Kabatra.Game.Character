namespace Kabatra.Game.Character.Tests.Sizes
{
    using Kabatra.Game.Character.Sizes;

    public class CanCharacterFitTests
    {
        [Theory]
        [InlineData(SizeCategory.Fine, SizeCategory.Fine)]
        [InlineData(SizeCategory.Fine, SizeCategory.Diminiutive)]
        [InlineData(SizeCategory.Fine, SizeCategory.Tiny)]
        [InlineData(SizeCategory.Fine, SizeCategory.Small)]
        [InlineData(SizeCategory.Fine, SizeCategory.Medium)]
        [InlineData(SizeCategory.Fine, SizeCategory.Large)]
        [InlineData(SizeCategory.Fine, SizeCategory.Huge)]
        [InlineData(SizeCategory.Fine, SizeCategory.Gargantuan)]
        [InlineData(SizeCategory.Fine, SizeCategory.Colossal)]

        [InlineData(SizeCategory.Diminiutive, SizeCategory.Fine)]
        [InlineData(SizeCategory.Diminiutive, SizeCategory.Diminiutive)]
        [InlineData(SizeCategory.Diminiutive, SizeCategory.Tiny)]
        [InlineData(SizeCategory.Diminiutive, SizeCategory.Small)]
        [InlineData(SizeCategory.Diminiutive, SizeCategory.Medium)]
        [InlineData(SizeCategory.Diminiutive, SizeCategory.Large)]
        [InlineData(SizeCategory.Diminiutive, SizeCategory.Huge)]
        [InlineData(SizeCategory.Diminiutive, SizeCategory.Gargantuan)]
        [InlineData(SizeCategory.Diminiutive, SizeCategory.Colossal)]

        [InlineData(SizeCategory.Tiny, SizeCategory.Diminiutive)]
        [InlineData(SizeCategory.Tiny, SizeCategory.Tiny)]
        [InlineData(SizeCategory.Tiny, SizeCategory.Small)]
        [InlineData(SizeCategory.Tiny, SizeCategory.Medium)]
        [InlineData(SizeCategory.Tiny, SizeCategory.Large)]
        [InlineData(SizeCategory.Tiny, SizeCategory.Huge)]
        [InlineData(SizeCategory.Tiny, SizeCategory.Gargantuan)]
        [InlineData(SizeCategory.Tiny, SizeCategory.Colossal)]

        [InlineData(SizeCategory.Small, SizeCategory.Tiny)]
        [InlineData(SizeCategory.Small, SizeCategory.Small)]
        [InlineData(SizeCategory.Small, SizeCategory.Medium)]
        [InlineData(SizeCategory.Small, SizeCategory.Large)]
        [InlineData(SizeCategory.Small, SizeCategory.Huge)]
        [InlineData(SizeCategory.Small, SizeCategory.Gargantuan)]
        [InlineData(SizeCategory.Small, SizeCategory.Colossal)]

        [InlineData(SizeCategory.Medium, SizeCategory.Small)]
        [InlineData(SizeCategory.Medium, SizeCategory.Medium)]
        [InlineData(SizeCategory.Medium, SizeCategory.Large)]
        [InlineData(SizeCategory.Medium, SizeCategory.Huge)]
        [InlineData(SizeCategory.Medium, SizeCategory.Gargantuan)]
        [InlineData(SizeCategory.Medium, SizeCategory.Colossal)]

        [InlineData(SizeCategory.Large, SizeCategory.Medium)]
        [InlineData(SizeCategory.Large, SizeCategory.Large)]
        [InlineData(SizeCategory.Large, SizeCategory.Huge)]
        [InlineData(SizeCategory.Large, SizeCategory.Gargantuan)]
        [InlineData(SizeCategory.Large, SizeCategory.Colossal)]

        [InlineData(SizeCategory.Huge, SizeCategory.Large)]
        [InlineData(SizeCategory.Huge, SizeCategory.Huge)]
        [InlineData(SizeCategory.Huge, SizeCategory.Gargantuan)]
        [InlineData(SizeCategory.Huge, SizeCategory.Colossal)]

        [InlineData(SizeCategory.Gargantuan, SizeCategory.Huge)]
        [InlineData(SizeCategory.Gargantuan, SizeCategory.Gargantuan)]
        [InlineData(SizeCategory.Gargantuan, SizeCategory.Colossal)]

        [InlineData(SizeCategory.Colossal, SizeCategory.Gargantuan)]
        [InlineData(SizeCategory.Colossal, SizeCategory.Colossal)]
        public void CharacterCanFit(SizeCategory characterSize, SizeCategory spaceSize)
        {
            var characterFits = Size.CanCharacterFit(characterSize, spaceSize);
            Assert.True(characterFits);
        }

        [Theory]
        [InlineData(SizeCategory.Tiny, SizeCategory.Fine)]

        [InlineData(SizeCategory.Small, SizeCategory.Fine)]
        [InlineData(SizeCategory.Small, SizeCategory.Diminiutive)]

        [InlineData(SizeCategory.Medium, SizeCategory.Fine)]
        [InlineData(SizeCategory.Medium, SizeCategory.Diminiutive)]
        [InlineData(SizeCategory.Medium, SizeCategory.Tiny)]

        [InlineData(SizeCategory.Large, SizeCategory.Fine)]
        [InlineData(SizeCategory.Large, SizeCategory.Diminiutive)]
        [InlineData(SizeCategory.Large, SizeCategory.Tiny)]
        [InlineData(SizeCategory.Large, SizeCategory.Small)]

        [InlineData(SizeCategory.Huge, SizeCategory.Fine)]
        [InlineData(SizeCategory.Huge, SizeCategory.Diminiutive)]
        [InlineData(SizeCategory.Huge, SizeCategory.Tiny)]
        [InlineData(SizeCategory.Huge, SizeCategory.Small)]
        [InlineData(SizeCategory.Huge, SizeCategory.Medium)]

        [InlineData(SizeCategory.Gargantuan, SizeCategory.Fine)]
        [InlineData(SizeCategory.Gargantuan, SizeCategory.Diminiutive)]
        [InlineData(SizeCategory.Gargantuan, SizeCategory.Tiny)]
        [InlineData(SizeCategory.Gargantuan, SizeCategory.Small)]
        [InlineData(SizeCategory.Gargantuan, SizeCategory.Medium)]
        [InlineData(SizeCategory.Gargantuan, SizeCategory.Large)]

        [InlineData(SizeCategory.Colossal, SizeCategory.Fine)]
        [InlineData(SizeCategory.Colossal, SizeCategory.Diminiutive)]
        [InlineData(SizeCategory.Colossal, SizeCategory.Tiny)]
        [InlineData(SizeCategory.Colossal, SizeCategory.Small)]
        [InlineData(SizeCategory.Colossal, SizeCategory.Medium)]
        [InlineData(SizeCategory.Colossal, SizeCategory.Large)]
        [InlineData(SizeCategory.Colossal, SizeCategory.Huge)]
        public void CharacterCannotFit(SizeCategory characterSize, SizeCategory spaceSize)
        {
            var characterFits = Size.CanCharacterFit(characterSize, spaceSize);
            Assert.False(characterFits);
        }
    }
}
