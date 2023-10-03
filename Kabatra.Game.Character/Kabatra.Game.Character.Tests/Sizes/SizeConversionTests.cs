namespace Kabatra.Game.Character.Tests.Sizes
{
    using Kabatra.Game.Character.Sizes;

    public class SizeConversionTests
    {       
        [Theory]
        [InlineData(SizeCategory.Fine)]
        [InlineData(SizeCategory.Diminiutive)]
        [InlineData(SizeCategory.Tiny)]
        [InlineData(SizeCategory.Small)]
        [InlineData(SizeCategory.Medium)]
        [InlineData(SizeCategory.Large)]
        [InlineData(SizeCategory.Huge)]
        [InlineData(SizeCategory.Gargantuan)]
        [InlineData(SizeCategory.Colossal)]
        public void CanCovertSizeToSpaceControlRadiusInFeet(SizeCategory sizeCategory)
        {
            float expectedSizeInFeet;
            switch(sizeCategory)
            {
                case SizeCategory.Fine:
                    expectedSizeInFeet = .5f;
                    break;
                case SizeCategory.Diminiutive:
                    expectedSizeInFeet = 1f;
                    break;
                case SizeCategory.Tiny:
                    expectedSizeInFeet = 2.5f;
                    break;
                case SizeCategory.Small:
                    expectedSizeInFeet = 5f;
                    break;
                case SizeCategory.Medium:
                    expectedSizeInFeet = 5f;
                    break;
                case SizeCategory.Large:
                    expectedSizeInFeet = 10f;
                    break;
                case SizeCategory.Huge:
                    expectedSizeInFeet = 15f;
                    break;
                case SizeCategory.Gargantuan:
                    expectedSizeInFeet = 20f;
                    break;
                case SizeCategory.Colossal:
                    expectedSizeInFeet = 64f;
                    break;
                default:
                    expectedSizeInFeet = 0;
                    break;
            }

            var actualSizeInFeet = Convert.SizeToSpaceControlRadiusInFeet(sizeCategory);

            Assert.Equal(expectedSizeInFeet, actualSizeInFeet);
        }

        [Theory]
        [InlineData(0, 0, SizeCategory.Fine)]
        [InlineData(.5, .125, SizeCategory.Fine)]
        
        [InlineData(.51, .126, SizeCategory.Diminiutive)] // Min
        [InlineData(.51, 0, SizeCategory.Diminiutive)]    // Catch Height
        [InlineData(0, .126, SizeCategory.Diminiutive)]   // Catch Weight
        [InlineData(1, 1, SizeCategory.Diminiutive)]      // Max

        [InlineData(1.01, 1.01, SizeCategory.Tiny)] // Min
        [InlineData(1.01, 0, SizeCategory.Tiny)]    // Catch Height
        [InlineData(0, 1.01, SizeCategory.Tiny)]    // Catch Weight
        [InlineData(2, 8, SizeCategory.Tiny)]       // Max

        [InlineData(2.01, 8.01, SizeCategory.Small)] // Min
        [InlineData(2.01, 0, SizeCategory.Small)]    // Catch Height
        [InlineData(0, 8.01, SizeCategory.Small)]    // Catch Weight
        [InlineData(4, 60, SizeCategory.Small)]      // Max

        [InlineData(4.01, 60.01, SizeCategory.Medium)] // Min
        [InlineData(4.01, 0, SizeCategory.Medium)]     // Catch Height
        [InlineData(0, 60.01, SizeCategory.Medium)]    // Catch Weight
        [InlineData(8, 500, SizeCategory.Medium)]      // Max

        [InlineData(8.01, 500.01, SizeCategory.Large)] // Min
        [InlineData(8.01, 0, SizeCategory.Large)]      // Catch Height
        [InlineData(0, 500.01, SizeCategory.Large)]    // Catch Weight
        [InlineData(16, 4000, SizeCategory.Large)]     // Max

        [InlineData(16.01, 4000.01, SizeCategory.Huge)] // Min
        [InlineData(16.01, 0, SizeCategory.Huge)]       // Catch Height
        [InlineData(0, 4000.01, SizeCategory.Huge)]     // Catch Weight
        [InlineData(32, 32000, SizeCategory.Huge)]      // Max

        [InlineData(32.01, 32000.01, SizeCategory.Gargantuan)] // Min
        [InlineData(32.01, 0, SizeCategory.Gargantuan)]        // Catch Height
        [InlineData(0, 32000.01, SizeCategory.Gargantuan)]     // Catch Weight
        [InlineData(64, 250000, SizeCategory.Gargantuan)]      // Max

        [InlineData(64.01, 250000.01, SizeCategory.Colossal)] // Min
        [InlineData(64.01, 0, SizeCategory.Colossal)]         // Catch Height
        [InlineData(0, 250000.01, SizeCategory.Colossal)]     // Catch Weight
        public void CanConvertHeightAndWeightToSizeCategory(float heightInFeet, float weightInPounds, SizeCategory expectedSizeCategory)
        {
            var actualSizeCategory = Convert.HeightAndWeightToSizeCategory(heightInFeet, weightInPounds);

            Assert.Equal(expectedSizeCategory, actualSizeCategory);
        }
    }
}
