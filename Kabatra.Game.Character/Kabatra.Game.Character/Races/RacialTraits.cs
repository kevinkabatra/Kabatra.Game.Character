using Kabatra.Game.Character.Abilities;

namespace Kabatra.Game.Character.Races
{
    public class RacialTraits
    {
        public readonly AbilityScoreIncrease AbilityScoreIncrease;
        public readonly float Age; // Age is Years.Days


        public RacialTraits(
            AbilityScoreIncrease abilityScoreIncrease,
            float age
        ) 
        {
            AbilityScoreIncrease = abilityScoreIncrease;
            Age = age;
        }
    }

    public class AbilityScoreIncrease
    {
        public int Increase { get; set; }
        public Ability Ability { get; set; }
    }
}
