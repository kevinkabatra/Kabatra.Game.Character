namespace Kabatra.Game.Character.Tests.Races.Data.Elves
{
    using Kabatra.Game.Character.Races;
    using Kabatra.Game.Character.Races.Elves;

    public class GenericHighElf : GenericElf
    {
        public override IRace Get()
        {
            HighElf character = new(ExpectedAge, ExpectedAlignment, ExpectedHeightInFeet, ExpectedWeightInPounds);
            return character;
        }
    }

}
