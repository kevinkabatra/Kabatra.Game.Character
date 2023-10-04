namespace Kabatra.Game.Character.Languages
{
    /// <summary>
    /// <para>
    ///     Your race indicates the languages your character can speak by default, and your background might give you
    /// access to one or more additional languages of your choice. Note these languages on your character sheet.
    /// </para>
    /// <para>
    ///     Choose your languages from the Standard Languages table, or choose one that is common in your campaign.
    /// With your GM’s permission, you can instead choose a language from the Exotic Languages table or a secret
    /// language, such as thieves’ cant or the tongue of druids.
    /// </para>
    /// <para>
    ///     Some of these languages are actually families of languages with many dialects. For example, the
    /// Primordial language includes the Auran, Aquan, Ignan, and Terran dialects, one for each of the four
    /// elemental planes. Creatures that speak different dialects of the same language can communicate with
    /// one another.
    /// </para>
    /// </summary>
    /// <remarks>System Reference Document Page 59</remarks>
    public enum Language
    {
        #region Standard Languages
        Common,
        Dwarvish,
        Elvish,
        Giant,
        Gnomish,
        Goblin,
        Halfling,
        Orc,
        #endregion

        #region Exotic Languages
        Abyssal,
        Celestial,
        Draconic,
        DeepSpeach,
        Infernal,
        Primordial,
        Sylvan,
        Undercommon
        #endregion
    }
}
