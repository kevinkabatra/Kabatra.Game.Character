namespace Kabatra.Game.Character.Abilities
{
    using Skills;

    /// <summary>
    /// <para>
    ///     Each ability covers a broad range of capabilities, including skills that a character or a monster can be
    /// proficient in. A skill represents a specific aspect of an System Reference Document 5.1 78 ability score, and
    /// an individual’s proficiency in a skill demonstrates a focus on that aspect. (A character’s starting skill
    /// proficiencies are determined at character creation, and a monster’s skill proficiencies appear in the monster’s
    /// stat block.)
    /// </para>
    /// <para>
    ///     For example, a Dexterity check might reflect a character’s attempt to pull off an acrobatic stunt, to palm
    /// an object, or to stay hidden.Each of these aspects of Dexterity has an associated skill: Acrobatics, Sleight of
    /// Hand, and Stealth, respectively.So a character who has proficiency in the Stealth skill is particularly good at
    /// Dexterity checks related to sneaking and hiding.
    /// </para>
    /// <para>
    ///     The skills related to each ability score are shown in the following list. (No skills are related to Constitution.)
    /// See an ability’s description in the later sections of this section for examples of how to use a skill associated with an ability.
    /// </para>
    /// </summary>
    /// <remarks>System Reference Document Page 77, 78</remarks>
    public class AbilityAssociatedWithSkill
    {
        /// <summary>
        ///     Gets the ability related to each skill. No skills are related to Constitution.
        /// </summary>
        /// <param name="skill"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static Ability Get(Skill skill)
        {
            switch (skill)
            {
                case Skill.Athletics:
                    return Ability.Strength;
                case Skill.Acrobatics:
                case Skill.SleightOfHand:
                case Skill.Stealth:
                    return Ability.Dexterity;
                case Skill.Arcana:
                case Skill.History:
                case Skill.Investigation:
                case Skill.Nature:
                case Skill.Religion:
                    return Ability.Intelligence;

                case Skill.AnimalHandling:
                case Skill.Insight:
                case Skill.Medicine:
                case Skill.Perception:
                case Skill.Survival:
                    return Ability.Wisdom;
                
                case Skill.Deception:
                case Skill.Intimidation:
                case Skill.Performance:
                case Skill.Persuasion:
                    return Ability.Charisma;
                
                default: throw new NotImplementedException();
            }
        }

    }
}
