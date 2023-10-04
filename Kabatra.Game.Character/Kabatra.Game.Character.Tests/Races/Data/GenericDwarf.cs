namespace Kabatra.Game.Character.Tests.Races.Data
{
    using Kabatra.Game.Character.Alignments;
    using Kabatra.Game.Character.Races.Dwarves;

    public class GenericDwarf
    {
        public static readonly float ExpectedAge = 100F;
        public static readonly Alignment ExpectedAlignment = Alignment.LawfulGood;
        public static readonly float ExpectedHeightInFeet = 4.5f;
        public static readonly float ExpectedWeightInPounds = 200f;

        public static Dwarf Get()
        {
            Dwarf dwarf = new(ExpectedAge, ExpectedAlignment, ExpectedHeightInFeet, ExpectedWeightInPounds);
            return dwarf;
        }
    }
}
