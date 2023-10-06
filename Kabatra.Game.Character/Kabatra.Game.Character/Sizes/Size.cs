namespace Kabatra.Game.Character.Sizes
{
    /// <summary>
    ///     Characters of most races are Medium, a size category including creatures that are roughly 4 to 8 feet tall.
    /// Members of a few races are Small (between 2 and 4 feet tall), which means that certain rules of the game affect
    /// them differently. The most important of these rules is that Small characters have trouble wielding heavy weapons,
    /// as explained in “Equipment.”
    /// </summary>
    /// <remarks>System Reference Document Page 3</remarks>
    public class Size
    {
        public float Height { get; private set; }
        public float Weight { get; private set; }
        
        public SizeCategory SizeCategory { get; private set; }
        public float ControlRadiusInFeet { get; private set; }
        public bool IsCharacterSqueezed { get; private set; }

        public Size(float height, float weight)
        {
            Height = height;
            Weight = weight;
            SizeCategory = Convert.HeightAndWeightToSizeCategory(height, weight);
            ControlRadiusInFeet = Convert.SizeToSpaceControlRadiusInFeet(SizeCategory);
            IsCharacterSqueezed = false;
        }

        /// <summary>
        ///     Used to see if a given character can fit in its intended destination. Examples: cooridor, doorway, ledge.
        /// </summary>
        /// <param name="size"></param>
        /// <param name="spaceInFeet"></param>
        /// <returns></returns>
        public static bool CanCharacterFit(SizeCategory characterSize, SizeCategory spaceSize)
        {
            switch (characterSize)
            {
                case SizeCategory.Colossal:
                    return spaceSize >= SizeCategory.Gargantuan;
                case SizeCategory.Gargantuan:
                    return spaceSize >= SizeCategory.Huge;
                case SizeCategory.Huge:
                    return spaceSize >= SizeCategory.Large;
                case SizeCategory.Large:
                    return spaceSize >= SizeCategory.Medium;
                case SizeCategory.Medium:
                    return spaceSize >= SizeCategory.Small;
                case SizeCategory.Small:
                    return spaceSize >= SizeCategory.Tiny;
                case SizeCategory.Tiny:
                    return spaceSize >= SizeCategory.Diminiutive;
                case SizeCategory.Diminiutive:
                    return spaceSize >= SizeCategory.Fine;
                case SizeCategory.Fine:
                    return true;
                default: throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Squeezing into a Smaller Space
        ///     Squeezing into a Smaller Space A creature can squeeze through a space that is large enough for a creature
        /// one size smaller than it. Thus, a Large creature can squeeze through a passage that’s only 5 feet wide. While
        /// squeezing through a space, a creature must spend 1 extra foot for every foot it moves there, and it has
        /// disadvantage on attack rolls and Dexterity saving throws. Attack rolls against the creature have advantage
        /// while it’s in the smaller space.
        /// </summary>
        /// <param name="characterSizeInFeet"></param>
        /// <param name="spaceInFeet"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        /// <remarks>System Reference Document Page 92</remarks>
        public bool CheckIsCharacterSqueezed(SizeCategory spaceSize)
        {
            switch (SizeCategory)
            {
                case SizeCategory.Colossal:
                    IsCharacterSqueezed = spaceSize <= SizeCategory.Gargantuan;
                    return IsCharacterSqueezed;
                case SizeCategory.Gargantuan:
                    IsCharacterSqueezed = spaceSize <= SizeCategory.Huge;
                    return IsCharacterSqueezed;
                case SizeCategory.Huge:
                    IsCharacterSqueezed = spaceSize <= SizeCategory.Large;
                    return IsCharacterSqueezed;
                case SizeCategory.Large:
                    IsCharacterSqueezed = spaceSize <= SizeCategory.Medium;
                    return IsCharacterSqueezed;
                case SizeCategory.Medium:
                    IsCharacterSqueezed = spaceSize <= SizeCategory.Small;
                    return IsCharacterSqueezed;
                case SizeCategory.Small:
                    IsCharacterSqueezed = spaceSize <= SizeCategory.Tiny;
                    return IsCharacterSqueezed;
                case SizeCategory.Tiny:
                    IsCharacterSqueezed = spaceSize <= SizeCategory.Diminiutive;
                    return IsCharacterSqueezed;
                case SizeCategory.Diminiutive:
                    IsCharacterSqueezed = spaceSize <= SizeCategory.Fine;
                    return IsCharacterSqueezed;
                case SizeCategory.Fine:
                    IsCharacterSqueezed = false;
                    return IsCharacterSqueezed;
                default: throw new NotImplementedException();
            }
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
                Size characterSize = (Size)objectToCompare;
                return (
                    Height == characterSize.Height
                    && Weight == characterSize.Weight
                    && SizeCategory == characterSize.SizeCategory
                    && ControlRadiusInFeet == characterSize.ControlRadiusInFeet
                    && IsCharacterSqueezed== characterSize.IsCharacterSqueezed
                ) ;
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

    public class Convert
    {
        public static SizeCategory HeightAndWeightToSizeCategory(float heightInFeet, float weightInPounds)
        {
            if(heightInFeet > 64 || weightInPounds > 250000)
            {
                return SizeCategory.Colossal;
            }
            else if(heightInFeet > 32 || weightInPounds > 32000)
            {
                return SizeCategory.Gargantuan;
            }
            else if(heightInFeet >  16 || weightInPounds > 4000)
            {
                return SizeCategory.Huge;
            }
            else if(heightInFeet > 8 || weightInPounds > 500)
            {
                return SizeCategory.Large;
            }
            else if(heightInFeet > 4 || weightInPounds > 60)
            {
                return SizeCategory.Medium;
            }
            else if(heightInFeet > 2 || weightInPounds > 8)
            {
                return SizeCategory.Small;
            }
            else if(heightInFeet > 1 || weightInPounds > 1)
            {
                return SizeCategory.Tiny;
            }
            else if(heightInFeet > .5 || weightInPounds > .125)
            {
                return SizeCategory.Diminiutive;
            }
            else
            {
                return SizeCategory.Fine;
            }
        }

        public static float SizeToSpaceControlRadiusInFeet(SizeCategory size)
        {
            switch (size)
            {
                case SizeCategory.Fine:
                    return 0.5f;
                case SizeCategory.Diminiutive:
                    return 1f;
                case SizeCategory.Tiny:
                    return 2.5f;
                case SizeCategory.Small:
                    return 5f;
                case SizeCategory.Medium:
                    return 5f;
                case SizeCategory.Large:
                    return 10f;
                case SizeCategory.Huge:
                    return 15f;
                case SizeCategory.Gargantuan:
                    return 20f;
                case SizeCategory.Colossal:
                    return 64f;
                default: throw new NotImplementedException();
            }
        }
    }
}
