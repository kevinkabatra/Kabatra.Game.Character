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
        public float HeightInFeet;
        public float WeightInPounds;

        public Size Size { get; private set; }

        public RacialTraits(
            AbilityScoreIncrease abilityScoreIncrease,
            float age,
            Alignment alignment,
            float heightInFeet,
            float weightInPounds
        ) 
        {
            AbilityScoreIncrease = abilityScoreIncrease;
            Age = age;
            Alignment = alignment;
            HeightInFeet = heightInFeet;
            WeightInPounds= weightInPounds;
            Size = new(HeightInFeet, WeightInPounds);
        }
    }
}
