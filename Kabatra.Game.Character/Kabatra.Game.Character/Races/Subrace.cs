namespace Kabatra.Game.Character.Races
{
    /// <summary>
    ///     Some races have subraces. Members of a subrace have the traits of the parent race in addition to the traits
    /// specified for their subrace. Relationships among subraces vary significantly from race to race and world to world.
    /// </summary>
    /// <remarks>System Reference Document Page 3</remarks>
    public enum Subrace
    {
        #region Dwarf
        HillDwarf, // System Reference Document Page 4
        #endregion

        #region Elf
        HighElf, // System Reference Document Page 4
        #endregion

        #region Halfling
        LightFoot, // System Reference Document Page 5
        #endregion

        #region Gnome
        RockGnome, // System Reference Document Page 6
        #endregion
    }
}
