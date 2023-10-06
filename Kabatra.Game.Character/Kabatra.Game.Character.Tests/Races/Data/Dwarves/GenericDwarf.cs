namespace Kabatra.Game.Character.Tests.Races.Data.Dwarves
{
    using Kabatra.Game.Character.Alignments;
    using Kabatra.Game.Character.Races;
    using Kabatra.Game.Character.Races.Dwarves;

    public class GenericDwarf : IGenericRaceCreator
    {
        public float ExpectedAge { get => 100f; }
        public Alignment ExpectedAlignment { get => Alignment.LawfulGood; }
        public float ExpectedHeightInFeet { get => 4.5f; }
        public float ExpectedWeightInPounds { get => 200f; }

        public virtual IRace Get()
        {
            Dwarf character = new(ExpectedAge, ExpectedAlignment, ExpectedHeightInFeet, ExpectedWeightInPounds);
            return character;
        }
    }
}
