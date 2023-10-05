namespace Kabatra.Game.Character.Races.Elves
{
    using Kabatra.Game.Character.Abilities;
    using Kabatra.Game.Character.Alignments;
    using Kabatra.Game.Character.Languages;

    /// <summary>
    /// <para>
    ///     Your elf character has a variety of natural abilities, the result of thousands of years of elven refinement.
    /// </para>
    /// <para>
    /// 01. Ability Score Increase. Your Dexterity score increases by 2.
    /// </para>
    /// <para>
    /// 02. Age. Although elves reach physical maturity at about the same age as humans, the elven understanding of
    ///     adulthood goes beyond physical growth to encompass worldly experience. An elf typically claims adulthood and
    ///     an adult name around the age of 100 and can live to be 750 years old.
    /// </para>
    /// <para>
    /// 03. Alignment. Elves love freedom, variety, and selfexpression, so they lean strongly toward the gentler aspects of
    ///     chaos. They value and protect others’ freedom as well as their own, and they are more often good than not.
    /// </para>
    /// <para>
    /// 04. Size. Elves range from under 5 to over 6 feet tall and have slender builds. Your size is Medium.
    /// </para>
    /// <para>
    /// 05. Speed. Your base walking speed is 30 feet.
    /// </para>
    /// <para>
    /// 06. Darkvision: Accustomed to life underground, you have superior vision in dark and dim conditions. You can see in dim
    ///     light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern
    ///     color in darkness, only shades of gray.
    /// </para>
    /// <para>
    /// 07. Keen Senses. You have proficiency in the Perception skill.
    /// </para>
    /// <para>
    /// 08. Fey Ancestry. You have advantage on saving throws against being charmed, and magic can’t put you to sleep.
    /// </para>
    /// <para>
    /// 09. Trance. Elves don’t need to sleep. Instead, they meditate deeply, remaining semiconscious, for 4 hours a day. 
    ///     (The Common word for such meditation is “trance.”) While meditating, you can dream after a fashion; such dreams 
    ///     are actually mental exercises that have become reflexive through years of practice. After resting in this way,
    ///     you gain the same benefit that a human does from 8 hours of sleep.
    /// </para>
    /// <para>
    /// 09. Languages. You can speak, read, and write Common and Elvish. Elvish is fluid, with subtle intonations and 
    ///     intricate grammar. Elven literature is rich and varied, and their songs and poems are famous among other races. 
    ///     Many bards learn their language so they can add Elvish ballads to their repertoires.
    /// </para>
    /// </summary>
    /// <remarks>System Reference Document Page 4</remarks>
    public class Elf : RacialTraits
    {
        protected readonly static IEnumerable<AbilityScoreIncrease> BaseAbilityScoreIncrease = new List<AbilityScoreIncrease>() { new(Ability.Dexterity, 2) };
        protected readonly static string BaseRaceDisplayName = nameof(Elf);

        protected readonly static float BaseSpeedInFeet = 30f;
        protected readonly static IEnumerable<Language> BaseLanguages = new List<Language>() { Language.Common, Language.Elvish };

        protected Elf(IEnumerable<AbilityScoreIncrease> overrideAbilityScore, string overrideRaceDisplayName, float age, Alignment alignment, float heightInFeet, float weightInPounds) :
            base(overrideAbilityScore, age, alignment, heightInFeet, weightInPounds, BaseSpeedInFeet, BaseLanguages, overrideRaceDisplayName)
        {

        }

        public Elf(float age, Alignment alignment, float heightInFeet, float weightInPounds) :
            base(BaseAbilityScoreIncrease, age, alignment, heightInFeet, weightInPounds, BaseSpeedInFeet, BaseLanguages, BaseRaceDisplayName)
        {
        }
    }
}
