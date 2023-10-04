namespace Kabatra.Game.Character.Races
{
    using Abilities;
    using Alignments;
    using Kabatra.Game.Character.Languages;
    using Kabatra.Game.Character.Sizes;

    /// <summary>
    ///     The description of each race includes racial traits that are common to members of that race.
    /// </summary>
    /// <remarks>System Reference Document Page 3</remarks>    
    public class RacialTraits
    {
        public readonly AbilityScoreIncrease AbilityScoreIncrease;
        public readonly float Age; // Age is Years.Days
        public Alignment Alignment;
        public float HeightInFeet;
        public float WeightInPounds;
        public float SpeedInFeet;
        public IEnumerable<Language> Languages;

        public Size Size { get; private set; }

        protected RacialTraits(
            AbilityScoreIncrease abilityScoreIncrease,
            float age,
            Alignment alignment,
            float heightInFeet,
            float weightInPounds,
            float speedInFeet,
            IEnumerable<Language> languages
        ) 
        {
            AbilityScoreIncrease = abilityScoreIncrease;
            Age = age;
            Alignment = alignment;
            HeightInFeet = heightInFeet;
            WeightInPounds= weightInPounds;
            Size = new(HeightInFeet, WeightInPounds);
            SpeedInFeet = speedInFeet;
            Languages = languages;
        }
    }
}
