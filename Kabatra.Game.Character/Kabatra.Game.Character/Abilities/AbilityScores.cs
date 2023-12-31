﻿namespace Kabatra.Game.Character.Abilities
{
    /// <summary>
    /// <para>
    ///     Six abilities provide a quick description of every creature’s physical and mental characteristic.  
    /// </para>
    /// <para>
    ///     Is a character muscle-bound and insightful? Brilliant and charming? Nimble and hardy? Ability scores
    /// define these qualities—a creature’s assets as well as weaknesses.
    /// </para>
    /// <para>
    ///     The three main rolls of the game—the ability check, the saving throw, and the attack roll—rely on the
    /// six ability scores.The book’s introduction describes the basic rule behind these rolls: roll a d20, add an
    /// ability modifier derived from one of the six ability scores, and compare the total to a target number.
    /// </para>
    /// </summary>
    /// <remarks>System Reference Document Page 76</remarks>
    public partial class AbilityScores
    {
        /// <summary>
        ///     Strength, measuring physical power
        /// </summary>
        public int Strength { get; private set; }

        /// <summary>
        ///     Dexterity, measuring agility
        /// </summary>
        public int Dexterity { get; private set; }

        /// <summary>
        ///     Constitution, measuring endurance
        /// </summary>
        public int Constitution { get; private set; }

        /// <summary>
        ///     Intelligence, measuring reasoning and memory
        /// </summary>
        public int Intelligence { get; private set; }

        /// <summary>
        ///     Wisdom, measuring perception and insight
        /// </summary>
        public int Wisdom { get; private set; }

        /// <summary>
        ///     Charisma, measuring force of personality
        /// </summary>
        public int Charisma { get; private set; }

        public AbilityScores() 
        {
        }

        public AbilityScores(
            int strength,
            int dexterity,
            int constitution,
            int intelligence,
            int wisdom,
            int charisma)
        {
            SetAbilityScores(strength, dexterity, constitution, intelligence, wisdom, charisma);
        }

        /// <summary>
        ///     Gets ability score from a given ability, used for Ability Checks
        /// </summary>
        /// <param name="ability"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int GetScoreFromAbility(Ability ability)
        {
            switch (ability)
            {
                case Ability.Strength: return Strength;
                case Ability.Dexterity: return Dexterity;
                case Ability.Constitution: return Constitution;
                case Ability.Intelligence: return Intelligence;
                case Ability.Wisdom: return Wisdom;
                case Ability.Charisma: return Charisma;
                default: throw new NotImplementedException();
            }
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
    }
}
