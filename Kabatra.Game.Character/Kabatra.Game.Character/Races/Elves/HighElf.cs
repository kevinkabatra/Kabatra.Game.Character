namespace Kabatra.Game.Character.Races.Elves
{
    using Kabatra.Game.Character.Abilities;
    using Kabatra.Game.Character.Alignments;

    /// <summary>
    /// <para>
    ///     As a high elf, you have a keen mind and a mastery of at least the basics of magic. In many fantasy gaming worlds,
    /// there are two kinds of high elves. One type is haughty and reclusive, believing themselves to be superior to non-elves
    /// and even other elves. The other type is more common and more friendly, and often encountered among humans and other races.
    /// </para>
    /// <para>
    /// 1. Ability Score Increase. Your Intelligence score increases by 1.
    /// </para>
    /// <para>
    /// 2. Elf Weapon Training. You have proficiency with the longsword, shortsword, shortbow, and longbow.
    /// </para>
    /// <para>
    /// 3. Cantrip. You know one cantrip of your choice from the wizard spell list. Intelligence is your spellcasting ability for it.
    /// </para>
    /// <para>
    /// 4. Extra Language. You can speak, read, and write one extra language of your choice
    /// </para>
    /// </summary>
    public class HighElf : Elf
    {
        protected new readonly static IEnumerable<AbilityScoreIncrease> BaseAbilityScoreIncrease = new List<AbilityScoreIncrease>() {
            new(Ability.Dexterity, 2),
            new(Ability.Intelligence, 1),
        };

        protected new readonly static string BaseRaceDisplayName = "High Elf";

        public HighElf(float age, Alignment alignment, float heightInFeet, float weightInPounds) : base(BaseAbilityScoreIncrease, BaseRaceDisplayName, age, alignment, heightInFeet, weightInPounds)
        {
        }
    }
}
