namespace Kabatra.Game.Character.Races
{
    using Kabatra.Game.Character.Abilities;
    using Kabatra.Game.Character.Alignments;
    using Kabatra.Game.Character.Languages;
    using Kabatra.Game.Character.Sizes;

    /// <summary>
    ///     The description of each race includes racial traits that are common to members of that race.
    /// </summary>
    /// <remarks>System Reference Document Page 3</remarks>    
    public interface IRace
    {
        /// <summary>
        ///     Every race increases one or more of a character’s ability scores.
        /// </summary>
        public IEnumerable<AbilityScoreIncrease> AbilityScoreIncrease { get; set; }

        /// <summary>
        ///     The age entry notes the age when a member of the race is considered an adult, as well as the race’s expected
        /// lifespan. This information can help you decide how old your character is at the start of the game. You can choose
        /// any age for your character, which could provide an explanation for some of your ability scores. For example, if
        /// you play a young or very old character, your age could explain a particularly low Strength or Constitution score,
        /// while advanced age could account for a high Intelligence or Wisdom.
        /// </summary>
        public float Age { get; set; } // Age is Years.Days

        /// <summary>
        ///     Most races have tendencies toward certain alignments, described in this entry. These are not binding for player
        /// characters, but considering why your dwarf is chaotic, for example, in defiance of lawful dwarf society can help you
        /// better define your character.
        /// </summary>
        public Alignment Alignment { get; set; }

        /// <summary>
        ///     Height of character in feet, used to determine <c>Size</c>.
        /// </summary>
        public float HeightInFeet { get; set; }

        /// <summary>
        ///     Weight of character in pounds, used to determine <c>Size</c>.
        /// </summary>
        public float WeightInPounds { get; set; }

        /// <summary>
        ///     Your speed determines how far you can move when traveling ( “Adventuring”) and fighting (“Combat”).
        /// </summary>
        public float SpeedInFeet { get; set; }

        /// <summary>
        ///     By virtue of your race, your character can speak, read, and write certain languages.
        /// </summary>
        public IEnumerable<Language> Languages { get; set; }

        /// <summary>
        ///     Size of character, determined by height and weight.
        /// </summary>
        public Size Size { get; set; }

        /// <summary>
        ///     Name of Race to be displayed within UI
        /// </summary>
        public string RaceDisplayName { get; }
    }
}
