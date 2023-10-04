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

        /// <summary>
        ///     The age entry notes the age when a member of the race is considered an adult, as well as the race’s expected
        /// lifespan. This information can help you decide how old your character is at the start of the game. You can choose
        /// any age for your character, which could provide an explanation for some of your ability scores. For example, if
        /// you play a young or very old character, your age could explain a particularly low Strength or Constitution score,
        /// while advanced age could account for a high Intelligence or Wisdom.
        /// </summary>
        public readonly float Age; // Age is Years.Days
        
        public Alignment Alignment;
        public float HeightInFeet;
        public float WeightInPounds;

        /// <summary>
        ///     Your speed determines how far you can move when traveling ( “Adventuring”) and fighting (“Combat”).
        /// </summary>
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
