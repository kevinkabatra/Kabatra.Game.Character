namespace Kabatra.Game.Character.Abilities
{
    using Skills;

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
