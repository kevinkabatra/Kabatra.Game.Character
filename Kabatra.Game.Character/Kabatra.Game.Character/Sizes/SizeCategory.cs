namespace Kabatra.Game.Character.Sizes
{
    /// <summary>
    ///     Each creature takes up a different amount of space. The Size Categories table shows how much space a
    /// creature of a particular size controls in combat. Objects sometimes use the same size categories.
    /// </summary>
    /// <remarks>
    ///     1. System Reference Document Page 92
    ///     2. System Reference Document version 3.5: https://www.d20srd.org/srd/combat/movementPositionAndDistance.htm#tableCreatureSizeAndScale</remarks>
    public enum SizeCategory
    {
        /// <summary>
        ///     Height: 0.00 ft - 0.500 ft <br/>
        ///     Weight: 0.00 lb - 0.125 lb <br/>
        /// </summary>
        Fine,

        /// <summary>
        ///     Height: 0.51 ft -  1.00 ft <br/>
        ///     Weight: 0.126 lb - 1.00 lb <br/>
        /// </summary>
        Diminiutive,

        /// <summary>
        ///     Height: 1.01 ft - 2.00 ft <br/>
        ///     Weight: 1.01 lb - 8.00 lb <br/>
        /// </summary>
        Tiny,

        /// <summary>
        ///     Height: 2.01 ft -  4.00 ft <br/>
        ///     Weight: 8.01 lb - 60.00 lb <br/>
        /// </summary>
        Small,

        /// <summary>
        ///     Height:  4.01 ft -   8.00 ft <br/>
        ///     Weight: 60.01 lb - 500.00 lb <br/>
        /// </summary>
        Medium,

        /// <summary>
        ///     Height:   8.01 ft -    16.00 ft <br/>
        ///     Weight: 500.01 lb - 4,000.00 lb <br/>
        /// </summary>
        Large,

        /// <summary>
        ///     Height:   16.01 ft -     32.00 ft <br/>
        ///     Weight: 4000.01 lb - 32,000.00 lb <br/>
        /// </summary>
        Huge,

        /// <summary>
        ///     Height:     32.01 ft -      64.00 ft <br/>
        ///     Weight: 32,000.01 lb - 250,000.00 lb <br/>
        /// </summary>
        Gargantuan,

        /// <summary>
        ///     Height:      64.01 ft -> + <br/>
        ///     Weight: 250,001.00 lb -> + <br/>
        /// </summary>
        Colossal
    }
}
