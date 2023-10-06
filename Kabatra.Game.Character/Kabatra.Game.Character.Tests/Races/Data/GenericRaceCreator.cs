namespace Kabatra.Game.Character.Tests.Races.Data
{
    using System.Collections.Generic;
    using Kabatra.Game.Character.Abilities;
    using Kabatra.Game.Character.Alignments;
    using Kabatra.Game.Character.Languages;
    using Kabatra.Game.Character.Races;

    public class GenericRaceCreator : IGenericRaceCreator
    {
        public float ExpectedAge { get => 25F; }
        public Alignment ExpectedAlignment { get => Alignment.LawfulGood; } 
        public float ExpectedHeightInFeet { get => 6f; }
        public float ExpectedWeightInPounds { get => 200f; }

        public List<AbilityScoreIncrease> ExpectedAbilityScoreIncrease { get => new() { new(Ability.Constitution, 2) }; }
        public float ExpectedSpeedInFeet { get => 30f; }
        public IEnumerable<Language> ExpectedLanguages { get => new List<Language>() { Language.Common }; }

        public IRace Get()
        {
            GenericRace genericRace = new(
                ExpectedAbilityScoreIncrease,
                ExpectedAge,
                ExpectedAlignment,
                ExpectedHeightInFeet,
                ExpectedWeightInPounds,
                ExpectedSpeedInFeet,
                ExpectedLanguages
            );

            return genericRace;
        }
    }
}
