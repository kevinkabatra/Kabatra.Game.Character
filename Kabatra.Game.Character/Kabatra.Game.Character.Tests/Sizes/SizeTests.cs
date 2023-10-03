using Kabatra.Game.Character.Sizes;

namespace Kabatra.Game.Character.Tests.Sizes
{
    public class SizeTests
    {
        [Fact]
        public void CanCreateSize()
        {
            var expectedHeightInFeet = 1;
            var expectedWeightInPounds = 2;

            Size actualSize = new(expectedHeightInFeet, expectedWeightInPounds);

            Assert.NotNull(actualSize);
            Assert.Equal(expectedHeightInFeet, actualSize.Height);
            Assert.Equal(expectedWeightInPounds, actualSize.Weight);
            Assert.False(actualSize.IsCharacterSqueezed);
        }

        [Theory]
        [InlineData(0, SizeCategory.Fine)]
        [InlineData(.51, SizeCategory.Diminiutive)]
        [InlineData(1.01, SizeCategory.Tiny)]
        [InlineData(2.01, SizeCategory.Small)]
        [InlineData(4.01, SizeCategory.Medium)]
        [InlineData(8.01, SizeCategory.Large)]
        [InlineData(16.01, SizeCategory.Huge)]
        [InlineData(32.01, SizeCategory.Gargantuan)]
        [InlineData(64.01, SizeCategory.Colossal)]
        public void CanCreateSizeWithCorrectSizeCategory(float height, SizeCategory expectedSizeCategory)
        {
            Size size = new(height, 0);
            Assert.Equal(expectedSizeCategory, size.SizeCategory);
            
        }
    }
}
