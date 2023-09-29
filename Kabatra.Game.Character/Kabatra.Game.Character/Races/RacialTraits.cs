namespace Kabatra.Game.Character.Races
{
    using Abilities;
    using Alignments;

    public class RacialTraits
    {
        public readonly AbilityScoreIncrease AbilityScoreIncrease;
        public readonly float Age; // Age is Years.Days
        public Alignment Alignment;

        public RacialTraits(
            AbilityScoreIncrease abilityScoreIncrease,
            float age,
            Alignment alignment
        ) 
        {
            AbilityScoreIncrease = abilityScoreIncrease;
            Age = age;
            Alignment = alignment;
        }
    }

    public class AbilityScoreIncrease
    {
        public Ability Ability;
        public int Increase;

        public AbilityScoreIncrease(Ability ability, int increase)
        {
            Ability= ability;
            Increase = increase;
        }
    }
}
