using System.Drawing;

namespace Kabatra.Game.Character.Sizes
{
    /// <summary>
    /// Space
    ///     A creature’s space is the area in feet that it effectively controls in combat, not an expression of its
    /// physical dimensions. A typical Medium creature isn’t 5 feet wide, for example, but it does control a space
    /// that wide. If a Medium hobgoblin stands in a 5- foot-wide doorway, other creatures can’t get through unless
    /// the hobgoblin lets them. 
    ///     A creature’s space also reflects the area it needs to fight effectively. For that reason, there’s a 
    /// limit to the number of creatures that can surround another creature in combat. Assuming Medium combatants,
    /// eight creatures can fit in a 5-foot radius around another one. 
    ///     Because larger creatures take up more space, fewer of them can surround a creature. If five Large
    /// creatures crowd around a Medium or smaller one, there’s little room for anyone else. In contrast, as many as
    /// twenty Medium creatures can surround a Gargantuan one.
    /// 
    /// </summary>
    /// <remarks>System Reference Document Page 92</remarks>
    public class SpaceControlled
    {
        public readonly float ControlRadiusInFeet;
        public bool IsCharacterSqueezed { get; private set; }

        public SpaceControlled(float controlRadiusInFeet)
        {
            ControlRadiusInFeet = controlRadiusInFeet;
            IsCharacterSqueezed = false;
        }

        /// <summary>
        ///     Used to see if a given character can fit in its intended destination. Examples: cooridor, doorway, ledge.
        /// </summary>
        /// <param name="size"></param>
        /// <param name="spaceInFeet"></param>
        /// <returns></returns>
        public static bool CanCharacterFit(Size size, float spaceInFeet)
        {
            switch(size)
            {
                case Size.Gargantuan:
                    return spaceInFeet >= ConvertTo.SizeInFeet(Size.Huge);
                case Size.Huge:
                    return spaceInFeet >= ConvertTo.SizeInFeet(Size.Large);
                case Size.Large:
                    return spaceInFeet >= ConvertTo.SizeInFeet(Size.Medium);
                case Size.Medium:
                    return spaceInFeet >= ConvertTo.SizeInFeet(Size.Small);
                case Size.Small:
                    return spaceInFeet >= ConvertTo.SizeInFeet(Size.Tiny);
                case Size.Tiny:
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
        public bool CheckIsCharacterSqueezed(Size size, float spaceInFeet)
        {
            switch(size)
            {
                case Size.Gargantuan:
                    if(spaceInFeet >= ConvertTo.SizeInFeet(Size.Huge))
                    {
                        IsCharacterSqueezed = false;
                        return IsCharacterSqueezed;
                    }
                    else
                    {
                        IsCharacterSqueezed = true;
                        return IsCharacterSqueezed;
                    }
                    
                case Size.Huge:
                    if (spaceInFeet >= ConvertTo.SizeInFeet(Size.Large))
                    {
                        IsCharacterSqueezed = false;
                        return IsCharacterSqueezed;
                    }
                    else
                    {
                        IsCharacterSqueezed = true;
                        return IsCharacterSqueezed;
                    }

                case Size.Large:
                    if (spaceInFeet >= ConvertTo.SizeInFeet(Size.Medium))
                    {
                        IsCharacterSqueezed = false;
                        return IsCharacterSqueezed;
                    }
                    else
                    {
                        IsCharacterSqueezed = true;
                        return IsCharacterSqueezed;
                    }

                case Size.Medium:
                    if (spaceInFeet >= ConvertTo.SizeInFeet(Size.Small))
                    {
                        IsCharacterSqueezed = false;
                        return IsCharacterSqueezed;
                    }
                    else
                    {
                        IsCharacterSqueezed = true;
                        return IsCharacterSqueezed;
                    }

                case Size.Small:
                    if (spaceInFeet >= ConvertTo.SizeInFeet(Size.Tiny))
                    {
                        IsCharacterSqueezed = false;
                        return IsCharacterSqueezed;
                    }
                    else
                    {
                        IsCharacterSqueezed = true;
                        return IsCharacterSqueezed;
                    }

                case Size.Tiny:
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
        public override bool Equals(Object? objectToCompare)
        {
            //Check for null and compare run-time types.
            if ((objectToCompare == null) || !GetType().Equals(objectToCompare.GetType()))
            {
                return false;
            }
            else
            {
                SpaceControlled spaceControlled = (SpaceControlled)objectToCompare;
                return (ControlRadiusInFeet == spaceControlled.ControlRadiusInFeet)
                    && (IsCharacterSqueezed == spaceControlled.IsCharacterSqueezed);
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
}
