namespace Kabatra.Game.Character.Abilities
{
    /// <summary>
    ///     Every race increases one or more of a character’s ability scores.
    /// </summary>
    /// <remarks>System Reference Document Page 3</remarks>
    public class AbilityScoreIncrease
    {
        public Ability Ability;
        public int Increase;

        public AbilityScoreIncrease(Ability ability, int increase)
        {
            Ability = ability;
            Increase = increase;
        }

        /// <summary>
        ///     Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="objectToCompare"></param>
        /// <returns></returns>
        public override bool Equals(object? objectToCompare)
        {
            //Check for null and compare run-time types.
            if ((objectToCompare == null) || !GetType().Equals(objectToCompare.GetType()))
            {
                return false;
            }
            else
            {
                AbilityScoreIncrease abilityScoreIncrease = (AbilityScoreIncrease)objectToCompare;
                return (
                    Ability == abilityScoreIncrease.Ability
                    && Increase == abilityScoreIncrease.Increase
                );
            }
        }

        /// <summary>
        ///     Required when overriding Equals.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
