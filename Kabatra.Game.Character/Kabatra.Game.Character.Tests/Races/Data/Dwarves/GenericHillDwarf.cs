namespace Kabatra.Game.Character.Tests.Races.Data.Dwarves
{
    using Kabatra.Game.Character.Races.Dwarves;

    public class GenericHillDwarf : GenericDwarf
    {
        new public static HillDwarf Get()
        {
            HillDwarf hillDwarf = new(ExpectedAge, ExpectedAlignment, ExpectedHeightInFeet, ExpectedWeightInPounds);
            return hillDwarf;
        }
    }
}
