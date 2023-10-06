namespace Kabatra.Game.Character.Tests.Races.Data.Dwarves
{
    using Kabatra.Game.Character.Races;
    using Kabatra.Game.Character.Races.Dwarves;

    public class GenericHillDwarf : GenericDwarf
    {
        public override IRace Get()
        {
            HillDwarf character = new(ExpectedAge, ExpectedAlignment, ExpectedHeightInFeet, ExpectedWeightInPounds);
            return character;
        }
    }
}
