namespace Kabatra.Game.Character.Sizes
{
    /// <summary>
    ///     Each creature takes up a different amount of space. The Size Categories table shows how much space a
    /// creature of a particular size controls in combat. Objects sometimes use the same size categories.
    /// </summary>
    /// <remarks>System Reference Document Page 92</remarks>
    public enum Size
    {
        Tiny,
        Small,
        Medium,
        Large,
        Huge,
        Gargantuan
    }

    public class ConvertTo
    {
        public static float SizeInFeet(Size size)
        {
            switch(size)
            {
                case Size.Tiny:
                    return 2.5f;
                case Size.Small:
                    return 5f;
                case Size.Medium:
                    return 5f;
                case Size.Large:
                    return 10f;
                case Size.Huge:
                    return 15f;
                case Size.Gargantuan:
                    return 20f;
                default: throw new NotImplementedException();
            }
        }
    }
}
