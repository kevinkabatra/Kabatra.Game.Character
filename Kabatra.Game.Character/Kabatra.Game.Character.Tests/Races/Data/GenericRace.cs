namespace Kabatra.Game.Character.Tests.Races.Data
{
    using System.Collections.Generic;
    using Kabatra.Game.Character.Abilities;
    using Kabatra.Game.Character.Alignments;
    using Kabatra.Game.Character.Languages;
    using Kabatra.Game.Character.Races;

    public class GenericRace : RacialTraits
    {
        public static readonly AbilityScoreIncrease ExpectedAbilityScoreIncrease = new(Ability.Constitution, 2);
        public static readonly float ExpectedAge = 25F;
        public static readonly Alignment ExpectedAlignment = Alignment.LawfulGood;
        public static readonly float ExpectedHeightInFeet = 6f;
        public static readonly float ExpectedWeightInPounds = 200f;
        public static readonly float ExpectedSpeedInFeet = 30f;
        public static readonly IEnumerable<Language> ExpectedLanguages = new List<Language>() { Language.Common };

        public GenericRace(AbilityScoreIncrease abilityScoreIncrease, float age, Alignment alignment, float heightInFeet, float weightInPounds, float speedInFeet, IEnumerable<Language> languages) :
            base(abilityScoreIncrease, age, alignment, heightInFeet, weightInPounds, speedInFeet, languages)
        {
        }

        public static RacialTraits Get()
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
