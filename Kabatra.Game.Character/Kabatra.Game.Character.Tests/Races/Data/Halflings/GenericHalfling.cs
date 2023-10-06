namespace Kabatra.Game.Character.Tests.Races.Data.Halflings
{
    using Kabatra.Game.Character.Alignments;
    using Kabatra.Game.Character.Races;
    using Kabatra.Game.Character.Races.Halflings;

    public class GenericHalfling : IGenericRaceCreator
    {
        public float ExpectedAge { get => 40F; }
        public Alignment ExpectedAlignment { get => Alignment.LawfulGood; }
        public float ExpectedHeightInFeet { get => 3f; }
        public float ExpectedWeightInPounds { get => 40f; }

        public virtual IRace Get()
        {
            Halfling character = new(ExpectedAge, ExpectedAlignment, ExpectedHeightInFeet, ExpectedWeightInPounds);
            return character;
        }
    }
}
