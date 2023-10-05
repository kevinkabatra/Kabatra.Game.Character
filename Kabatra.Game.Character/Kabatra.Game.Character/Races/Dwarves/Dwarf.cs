namespace Kabatra.Game.Character.Races.Dwarves
{
    using Kabatra.Game.Character.Abilities;
    using Kabatra.Game.Character.Alignments;
    using Kabatra.Game.Character.Languages;

    /// <summary>
    ///     Your dwarf character has an assortment of inborn abilities, part and parcel of dwarven nature.
    /// 01. Ability Score Increase: Your Constitution score increases by 2.
    /// 02. Age: Dwarves mature at the same rate as humans, but they’re considered young until they reach the age of 50.
    ///     On average, they live about 350 years.
    /// 03. Alignment: Most dwarves are lawful, believing firmly in the benefits of a well-ordered society. They tend 
    ///     toward good as well, with a strong sense of fair play and a belief that everyone deserves to share in the benefits
    ///     of a just order.
    /// 04. Size: Dwarves stand between 4 and 5 feet tall and average about 150 pounds. Your size is Medium. 
    /// 05. Speed: Your base walking speed is 25 feet. Your speed is not reduced by wearing heavy armor.
    /// 06. Darkvision: Accustomed to life underground, you have superior vision in dark and dim conditions. You can see in dim
    ///     light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern
    ///     color in darkness, only shades of gray.
    /// 07. Dwarven Resilience: You have advantage on saving throws against poison, and you have resistance against poison damage.
    /// 08. Dwarven Combat Training: You have proficiency with the battleaxe, handaxe, light hammer, and warhammer.
    /// 09. Tool Proficiency: You gain proficiency with the artisan’s tools of your choice: smith’s tools, brewer’s supplies, or 
    ///     mason’s tools.
    /// 10. Stonecunning: Whenever you make an Intelligence (History) check related to the origin of stonework, you are considered
    ///     proficient in the History skill and add double your proficiency bonus to the check, instead of your normal proficiency
    ///     bonus.
    /// 11. Languages. You can speak, read, and write Common and Dwarvish. Dwarvish is full of hard consonants and guttural sounds,
    ///     and those characteristics spill over into whatever other language a dwarf might speak.
    /// </summary>
    /// <remarks>System Reference Document Page 3</remarks>
    public class Dwarf : RacialTraits
    {
        protected readonly static IEnumerable<AbilityScoreIncrease> DwarfBaseAbilityScoreIncrease = new List<AbilityScoreIncrease>() { new(Ability.Constitution, 2) };
        protected readonly static string DwarfBaseRaceDisplayName = nameof(Dwarf);

        protected readonly static float DwarfBaseSpeedInFeet = 25f;
        protected readonly static IEnumerable<Language> DwarfBaseLanguages = new List<Language>() { Language.Common, Language.Dwarvish };

        protected Dwarf(IEnumerable<AbilityScoreIncrease> overrideAbilityScore, string overrideRaceDisplayName, float age, Alignment alignment, float heightInFeet, float weightInPounds) :
            base(overrideAbilityScore, age, alignment, heightInFeet, weightInPounds, DwarfBaseSpeedInFeet, DwarfBaseLanguages, overrideRaceDisplayName)
        {

        }

        public Dwarf(float age, Alignment alignment, float heightInFeet, float weightInPounds) :
            base(DwarfBaseAbilityScoreIncrease, age, alignment, heightInFeet, weightInPounds, DwarfBaseSpeedInFeet, DwarfBaseLanguages, DwarfBaseRaceDisplayName)
        {
        }
    }
}
