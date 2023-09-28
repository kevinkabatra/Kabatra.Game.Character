namespace Kabatra.Game.Character.Abilities
{
    public partial class AbilityScores
    {
        /// <summary>
        ///     Gets modifier for ability
        /// </summary>
        /// <returns></returns>
        public int GetStrengthModifier()
        {
            return GetAbilityModifier(Strength);
        }

        /// <summary>
        ///     Gets modifier for ability
        /// </summary>
        /// <returns></returns>
        public int GetDexterityModifier()
        {
            return GetAbilityModifier(Dexterity);
        }

        /// <summary>
        ///     Gets modifier for ability
        /// </summary>
        /// <returns></returns>
        public int GetConstitutionModifier()
        {
            return GetAbilityModifier(Constitution);
        }

        /// <summary>
        ///     Gets modifier for ability
        /// </summary>
        /// <returns></returns>
        public int GetIntelligenceModifier()
        {
            return GetAbilityModifier(Intelligence);
        }

        /// <summary>
        ///     Gets modifier for ability
        /// </summary>
        /// <returns></returns>
        public int GetWisdomModifier()
        {
            return GetAbilityModifier(Wisdom);
        }

        /// <summary>
        ///     Gets modifier for ability
        /// </summary>
        /// <returns></returns>
        public int GetCharismaModifier()
        {
            return GetAbilityModifier(Charisma);
        }

        /// <summary>
        ///     Each of	a creature’s abilities has a score,	a number that defines the magnitude of that ability. An 
        /// ability score is not just a measure of innate capabilities, but also encompasses a creature’s training
        /// and competence in activities related to that ability.
        ///     A score of 10 or 11	is the normal human average, but adventurers and many monsters are a cut above
        /// average	in	most abilities. A score of 18 is the highest that a person usually reaches. Adventurers can 
        /// have scores	as high as 20, and monsters and divine beings can have scores as high as 30.
        ///     Each ability also has a modifier, derived from the score and ranging from −5 (for an ability score of 1)
        /// to +10 (for	a score of 30).	The Ability Scores and Modifiers table notes the ability modifiers for the 
        /// range of possible ability scores, from 1 to 30.
        /// </summary>
        /// <param name="abilityScore"></param>
        /// <returns></returns>
        private static int GetAbilityModifier(int abilityScore)
        {
            switch (abilityScore)
            {
                case 1:
                    return -5;
                case 2:
                case 3:
                    return -4;
                case 4:
                case 5:
                    return -3;
                case 6:
                case 7:
                    return -2;
                case 8:
                case 9:
                    return -1;
                case 10:
                case 11:
                    return 0;
                case 12:
                case 13:
                    return 1;
                case 14:
                case 15:
                    return 2;
                case 16:
                case 17:
                    return 3;
                case 18:
                case 19:
                    return 4;
                case 20:
                case 21:
                    return 5;
                case 22:
                case 23:
                    return 6;
                case 24:
                case 25:
                    return 7;
                case 26:
                case 27:
                    return 8;
                case 28:
                case 29:
                    return 9;
                case 30:
                    return 10;
                default:
                    if (abilityScore <= 0)
                    {
                        return -5;
                    }

                    if (abilityScore > 30)
                    {
                        return 10;
                    }

                    return 0;
            }
        }
    }
}
