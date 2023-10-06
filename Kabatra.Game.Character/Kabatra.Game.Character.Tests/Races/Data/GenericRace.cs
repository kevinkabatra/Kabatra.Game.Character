namespace Kabatra.Game.Character.Tests.Races.Data
{
    using Kabatra.Game.Character.Abilities;
    using Kabatra.Game.Character.Alignments;
    using Kabatra.Game.Character.Languages;
    using Kabatra.Game.Character.Races;

    public class GenericRace : Race
    {
        public GenericRace(List<AbilityScoreIncrease> abilityScoreIncrease, float age, Alignment alignment, float heightInFeet, float weightInPounds, float speedInFeet, IEnumerable<Language> languages) :
            base(abilityScoreIncrease, age, alignment, heightInFeet, weightInPounds, speedInFeet, languages, nameof(GenericRaceCreator))
        {
        }
    }
}
