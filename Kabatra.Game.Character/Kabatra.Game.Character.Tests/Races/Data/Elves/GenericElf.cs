namespace Kabatra.Game.Character.Tests.Races.Data.Elves
{
    using Kabatra.Game.Character.Alignments;
    using Kabatra.Game.Character.Races.Elves;

    public class GenericElf
    {
        public static readonly float ExpectedAge = 100F;
        public static readonly Alignment ExpectedAlignment = Alignment.ChaoticGood;
        public static readonly float ExpectedHeightInFeet = 6f;
        public static readonly float ExpectedWeightInPounds = 120f;

        public static Elf Get()
        {
            Elf dwarf = new(ExpectedAge, ExpectedAlignment, ExpectedHeightInFeet, ExpectedWeightInPounds);
            return dwarf;
        }
    }
}
