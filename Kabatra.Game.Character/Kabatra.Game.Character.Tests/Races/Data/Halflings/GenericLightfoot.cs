namespace Kabatra.Game.Character.Tests.Races.Data.Halflings
{
    using Kabatra.Game.Character.Races;
    using Kabatra.Game.Character.Races.Halflings;

    public class GenericLightfoot : GenericHalfling
    {
        public override IRace Get()
        {
            Lightfoot character = new(ExpectedAge, ExpectedAlignment, ExpectedHeightInFeet, ExpectedWeightInPounds);
            return character;
        }
    }
}
