namespace Kabatra.Game.Character.Races.Halflings
{
    using Kabatra.Game.Character.Abilities;
    using Kabatra.Game.Character.Alignments;

    /// <summary>
    /// <para>
    ///     As a lightfoot halfling, you can easily hide from notice, even using other people as cover. You’re inclined
    /// to be affable and get along well with others. Lightfoots are more prone to wanderlust than other halflings, and
    /// often dwell alongside other races or take up a nomadic life.
    /// </para>
    /// <para>
    /// 1. Ability Score Increase. Your Charisma score increases by 1.
    /// </para>
    /// <para>
    /// 2. Naturally Stealthy. You can attempt to hide even when you are obscured only by a creature that is at least one size larger than you.
    /// </para>
    /// </summary>
    public class Lightfoot : Halfling
    {
        protected new readonly static IEnumerable<AbilityScoreIncrease> BaseAbilityScoreIncrease = new List<AbilityScoreIncrease>() {
            new(Ability.Dexterity, 2),
            new(Ability.Charisma, 1),
        };

        protected new readonly static string BaseRaceDisplayName = nameof(Lightfoot);

        public Lightfoot(float age, Alignment alignment, float heightInFeet, float weightInPounds) : base(BaseAbilityScoreIncrease, BaseRaceDisplayName, age, alignment, heightInFeet, weightInPounds)
        {
        }
    }
}
