namespace Kabatra.Game.Character.Tests.Races.Data.Elves
{
    using Kabatra.Game.Character.Alignments;
    using Kabatra.Game.Character.Races;
    using Kabatra.Game.Character.Races.Elves;

    public class GenericElf : IGenericRaceCreator
    {
        public float ExpectedAge { get => 100f; }
        public Alignment ExpectedAlignment { get => Alignment.ChaoticGood; }
        public float ExpectedHeightInFeet { get => 6f; }
        public float ExpectedWeightInPounds { get => 120f; }

        public virtual IRace Get()
        {
            Elf character = new(ExpectedAge, ExpectedAlignment, ExpectedHeightInFeet, ExpectedWeightInPounds);
            return character;
        }
    }
}
