namespace Kabatra.Game.Character.Tests.Races.Data.Elves
{
    using Kabatra.Game.Character.Races.Elves;

    public class GenericHighElf : GenericElf
    {
        new public static HighElf Get()
        {
            HighElf highElf = new(ExpectedAge, ExpectedAlignment, ExpectedHeightInFeet, ExpectedWeightInPounds);
            return highElf;
        }
    }

}
