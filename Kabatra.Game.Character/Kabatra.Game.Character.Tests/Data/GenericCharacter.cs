namespace Kabatra.Game.Character.Tests.Data
{
    using Kabatra.Game.Character.Abilities;
    using Kabatra.Game.Character.Races;
    using Kabatra.Game.Character.Tests.Races.Data;

    public class GenericCharacter
    {
        private static readonly int Strength = 10;
        private static readonly int Dexterity = 11;
        private static readonly int Constitution = 12;
        private static readonly int Intelligence = 13;
        private static readonly int Wisdom = 14;
        private static readonly int Charisma = 15;

        public readonly AbilityScores ExpectedAbilityScores = new(
            Strength,
            Dexterity,
            Constitution,
            Intelligence,
            Wisdom,
            Charisma
        );

        public readonly IRace ExpectedRace;

        public GenericCharacter()
        {
            GenericRaceCreator raceCreator = new();
            ExpectedRace = raceCreator.Get();
        }
        
        /// <summary>
        ///     Use intance versus static to avoid race conditions within tests.
        /// </summary>
        /// <returns></returns>
        public Character Get()
        {
            Character character = new(ExpectedAbilityScores, ExpectedRace);
            return character;
        }
    }
}
