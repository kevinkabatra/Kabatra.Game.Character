namespace Kabatra.Game.Character.Tests.Races
{
    using System.Collections.Generic;
    using Kabatra.Game.Character.Abilities;
    using Kabatra.Game.Character.Alignments;
    using Kabatra.Game.Character.Languages;
    using Kabatra.Game.Character.Races;

    public class GenericRace : RacialTraits
    {
        public GenericRace(AbilityScoreIncrease abilityScoreIncrease, float age, Alignment alignment, float heightInFeet, float weightInPounds, float speedInFeet, IEnumerable<Language> languages) :
            base(abilityScoreIncrease, age, alignment, heightInFeet, weightInPounds, speedInFeet, languages)
        {
        }
    }
}
