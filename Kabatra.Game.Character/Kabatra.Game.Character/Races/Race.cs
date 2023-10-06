namespace Kabatra.Game.Character.Races
{
    using Abilities;
    using Alignments;
    using Kabatra.Game.Character.Languages;
    using Kabatra.Game.Character.Sizes;

    /// <summary>
    ///     Implments <see cref="IRace"/>.
    /// </summary>
    public abstract class Race : IRace
    {
        public IEnumerable<AbilityScoreIncrease> AbilityScoreIncrease { get; set; }
        public float Age { get; set; }
        public Alignment Alignment { get; set; }
        public float HeightInFeet { get; set; }
        public float WeightInPounds { get; set; }
        public float SpeedInFeet { get; set; }
        public IEnumerable<Language> Languages { get; set; }
        public Size Size { get; set; }
        public string RaceDisplayName { get; private set; }

        protected Race(
            IEnumerable<AbilityScoreIncrease> abilityScoreIncrease,
            float age,
            Alignment alignment,
            float heightInFeet,
            float weightInPounds,
            float speedInFeet,
            IEnumerable<Language> languages,
            string raceDisplayName
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
            RaceDisplayName= raceDisplayName;
        }
    }
}
