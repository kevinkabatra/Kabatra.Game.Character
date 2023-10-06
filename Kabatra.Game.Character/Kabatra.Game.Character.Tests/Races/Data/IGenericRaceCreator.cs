namespace Kabatra.Game.Character.Tests.Races.Data
{
    using Kabatra.Game.Character.Alignments;
    using Kabatra.Game.Character.Races;

    /// <summary>
    ///     Interface for race creation for testing.
    /// </summary>
    public interface IGenericRaceCreator
    {
        public float ExpectedAge { get; }
        public Alignment ExpectedAlignment { get; }
        public float ExpectedHeightInFeet { get; }
        public float ExpectedWeightInPounds { get; }

        /// <summary>
        ///     Creates and returns new instance.
        /// </summary>
        /// <returns></returns>
        public IRace Get();
    }
}
