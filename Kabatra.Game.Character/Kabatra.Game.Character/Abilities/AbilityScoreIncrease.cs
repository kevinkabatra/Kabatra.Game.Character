namespace Kabatra.Game.Character.Abilities
{
    public class AbilityScoreIncrease
    {
        public Ability Ability;
        public int Increase;

        public AbilityScoreIncrease(Ability ability, int increase)
        {
            Ability = ability;
            Increase = increase;
        }
    }
}
