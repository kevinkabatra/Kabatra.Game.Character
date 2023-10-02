namespace Kabatra.Game.Character.Races
{
    using Abilities;
    using Alignments;
    using Kabatra.Game.Character.Sizes;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>System Reference Document Page 3</remarks>
    public class RacialTraits
    {
        public readonly AbilityScoreIncrease AbilityScoreIncrease;
        public readonly float Age; // Age is Years.Days
        public Alignment Alignment;
        public Size Size;
        public SpaceControlled SpaceControlled;

        public RacialTraits(
            AbilityScoreIncrease abilityScoreIncrease,
            float age,
            Alignment alignment,
            Size size
        ) 
        {
            AbilityScoreIncrease = abilityScoreIncrease;
            Age = age;
            Alignment = alignment;
            Size = size;
            SpaceControlled = new(ConvertTo.SizeInFeet(Size));
        }
    }
}
