namespace DDDSharp.Abstractions.Domain
{
    /// <summary>
    /// Represents a value object that implements equality comparison based on value.
    /// </summary>
    public interface IValueObject
    {
        /// <summary>
        /// Determines whether the specified value object is equal to the current value object.
        /// </summary>
        /// <param name="other">The value object to compare with the current value object.</param>
        /// <returns>true if the specified value object is equal to the current value object; otherwise, false.</returns>
        bool Equals(IValueObject? other);

        /// <summary>
        /// Returns a hash code for the current value object.
        /// </summary>
        /// <returns>A hash code for the current value object.</returns>
        int GetHashCode();
    }
}