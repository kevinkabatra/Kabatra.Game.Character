namespace Kabatra.Game.Character
{
    /// <summary>
    ///     Six	abilities provide a quick description of every creature’s physical and mental characteristic.
    ///     
    ///     Is a character muscle-bound and insightful? Brilliant and charming? Nimble and hardy? Ability scores
    /// define these qualities—a creature’s assets as well as weaknesses. The three main rolls of the game—the 
    /// ability check, the saving throw, and the attack roll—rely on the six ability scores.The book’s introduction
    /// describes the basic rule behind these rolls: roll a d20, add an ability modifier derived from one of the six
    /// ability scores, and compare the total to a target number.
    /// </summary>
    public partial class Character
    {
        /// <summary>
        ///     Strength, measuring physical power
        /// </summary>
        public int Strength { get; private set; }

        /// <summary>
        ///     Gets modifier for ability
        /// </summary>
        /// <returns></returns>
        public int GetStrengthModifier()
        {
            return GetAbilityModifier(Strength);
        }

        /// <summary>
        ///     Dexterity, measuring agility
        /// </summary>
        public int Dexterity { get; private set; }

        /// <summary>
        ///     Gets modifier for ability
        /// </summary>
        /// <returns></returns>
        public int GetDexterityModifier()
        {
            return GetAbilityModifier(Dexterity);
        }

        /// <summary>
        ///     Constitution, measuring endurance
        /// </summary>
        public int Constitution { get; private set; }

        /// <summary>
        ///     Gets modifier for ability
        /// </summary>
        /// <returns></returns>
        public int GetConstitutionModifier()
        {
            return GetAbilityModifier(Constitution);
        }

        /// <summary>
        ///     Intelligence, measuring reasoning and memory
        /// </summary>
        public int Intelligence { get; private set; }

        /// <summary>
        ///     Gets modifier for ability
        /// </summary>
        /// <returns></returns>
        public int GetIntelligenceModifier()
        {
            return GetAbilityModifier(Intelligence);
        }

        /// <summary>
        ///     Wisdom, measuring perception and insight
        /// </summary>
        public int Wisdom { get; private set; }

        /// <summary>
        ///     Gets modifier for ability
        /// </summary>
        /// <returns></returns>
        public int GetWisdomModifier()
        {
            return GetAbilityModifier(Wisdom);
        }

        /// <summary>
        ///     Charisma, measuring force of personality
        /// </summary>
        public int Charisma { get; private set; }

        /// <summary>
        ///     Gets modifier for ability
        /// </summary>
        /// <returns></returns>
        public int GetCharismaModifier()
        {
            return GetAbilityModifier(Charisma);
        }

        /// <summary>
        ///     Set the ability scores for a character, should be called during character construction.
        /// </summary>
        /// <param name="strength"></param>
        /// <param name="dexterity"></param>
        /// <param name="constitution"></param>
        /// <param name="intelligence"></param>
        /// <param name="wisdom"></param>
        /// <param name="charisma"></param>
        public void SetAbilityScores(
            int strength,
            int dexterity,
            int constitution,
            int intelligence,
            int wisdom,
            int charisma
        )
        {
            Strength = strength;
            Dexterity = dexterity;
            Constitution = constitution;
            Intelligence = intelligence;
            Wisdom = wisdom;
            Charisma = charisma;
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
                    if(abilityScore <= 0)
                    {
                        return -5;
                    }

                    if(abilityScore > 30)
                    {
                        return 10;
                    }

                    return 0;
            }
        }
    }
}
