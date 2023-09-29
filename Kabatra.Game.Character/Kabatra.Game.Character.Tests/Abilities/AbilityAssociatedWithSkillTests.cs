namespace Kabatra.Game.Character.Tests.Abilities
{
    using Kabatra.Game.Character.Abilities;
    using Skills;

    public class AbilityAssociatedWithSkillTests
    {
        [Theory]
        [InlineData(Skill.Athletics)]
        public void AbilititesAssociatedWithStrength(Skill skill)
        {
            var ability = AbilityAssociatedWithSkill.Get(skill);
            Assert.Equal(Ability.Strength, ability);
        }

        [Theory]
        [InlineData(Skill.Acrobatics)]
        [InlineData(Skill.SleightOfHand)]
        [InlineData(Skill.Stealth)]
        public void AbilititesAssociatedWithDexterity(Skill skill)
        {
            var ability = AbilityAssociatedWithSkill.Get(skill);
            Assert.Equal(Ability.Dexterity, ability);
        }

        [Theory]
        [InlineData(Skill.Arcana)]
        [InlineData(Skill.History)]
        [InlineData(Skill.Investigation)]
        [InlineData(Skill.Nature)]
        [InlineData(Skill.Religion)]
        public void AbilititesAssociatedWithIntelligence(Skill skill)
        {
            var ability = AbilityAssociatedWithSkill.Get(skill);
            Assert.Equal(Ability.Intelligence, ability);
        }

        [Theory]
        [InlineData(Skill.AnimalHandling)]
        [InlineData(Skill.Insight)]
        [InlineData(Skill.Medicine)]
        [InlineData(Skill.Perception)]
        [InlineData(Skill.Survival)]
        public void AbilititesAssociatedWithWisdom(Skill skill)
        {
            var ability = AbilityAssociatedWithSkill.Get(skill);
            Assert.Equal(Ability.Wisdom, ability);
        }

        [Theory]
        [InlineData(Skill.Deception)]
        [InlineData(Skill.Intimidation)]
        [InlineData(Skill.Performance)]
        [InlineData(Skill.Persuasion)]
        public void AbilititesAssociatedWithCharisma(Skill skill)
        {
            var ability = AbilityAssociatedWithSkill.Get(skill);
            Assert.Equal(Ability.Charisma, ability);
        }
    }
}
