namespace Kabatra.Game.Character.Races.Halflings
{
    using Kabatra.Game.Character.Abilities;
    using Kabatra.Game.Character.Alignments;
    using Kabatra.Game.Character.Languages;

    /// <summary>
    /// <para>
    /// 	Your halfling character has a number of traits in common with all other halflings.
    /// 	</para>
    /// <para>
    /// 01.	Ability Score Increase.Your Dexterity score increases by 2. Age.A halfling reaches adulthood at the age of 20
    ///     and generally lives into the middle of his or her second century.
    /// </para>
    /// <para>
    /// 02.	Alignment.Most halflings are lawful good.As a rule, they are good-hearted and kind, hate to see others in pain,
    ///     and have no tolerance for oppression.They are also very orderly and traditional, leaning heavily on the support
    ///     of their community and the comfort of their old ways.
    /// </para>
    /// <para>
    /// 03.	Size.Halflings average about 3 feet tall and weigh about 40 pounds.Your size is Small.Speed.Your base walking
    ///     speed is 25 feet.
    /// </para>
    /// <para>
    /// 04.	Lucky.When you roll a 1 on the d20 for an attack roll, ability check, or saving throw, you can reroll the die
    ///     and must use the new roll.
    /// </para>
    /// <para>
    /// 05.	Brave.You have advantage on saving throws against being frightened.
    /// </para>
    /// <para>
    /// 06.	Halfling Nimbleness.You can move through the space of any creature that is of a size larger than yours.
    /// </para>
    /// <para>
    /// 07.	Languages.You can speak, read, and write Common and Halfling.The Halfling language isn’t secret, but halflings
    ///     are loath to share it with others.They write very little, so they don’t have a rich body of literature.Their oral
    ///     tradition, however, is very strong. Almost all halflings speak Common to converse with the people in whose lands
    ///     they dwell or through which they are traveling.
    /// </para>
    /// </summary>
    /// <remarks>System Reference Document Page 4, 5</remarks>
    public class Halfling : Race
    {
        protected readonly static IEnumerable<AbilityScoreIncrease> BaseAbilityScoreIncrease = new List<AbilityScoreIncrease>() { new(Ability.Dexterity, 2) };
        protected readonly static string BaseRaceDisplayName = nameof(Halfling);

        protected readonly static float BaseSpeedInFeet = 25f;
        protected readonly static IEnumerable<Language> BaseLanguages = new List<Language>() { Language.Common, Language.Halfling };

        protected Halfling(IEnumerable<AbilityScoreIncrease> overrideAbilityScore, string overrideRaceDisplayName, float age, Alignment alignment, float heightInFeet, float weightInPounds) :
            base(overrideAbilityScore, age, alignment, heightInFeet, weightInPounds, BaseSpeedInFeet, BaseLanguages, overrideRaceDisplayName)
        {
        }

        public Halfling(float age, Alignment alignment, float heightInFeet, float weightInPounds) :
            base(BaseAbilityScoreIncrease, age, alignment, heightInFeet, weightInPounds, BaseSpeedInFeet, BaseLanguages, BaseRaceDisplayName)
        {
        }
    }
}
