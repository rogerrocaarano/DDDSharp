using System;

namespace DDDSharp.Abstractions.Domain
{
    /// <summary>
    /// Represents an entity that tracks creation and modification timestamps.
    /// </summary>
    public interface IAuditable
    {
        /// <summary>
        /// Gets the date and time when the entity was created.
        /// </summary>
        /// <returns>The creation timestamp.</returns>
        DateTime CreatedAt { get; }

        /// <summary>
        /// Gets the date and time when the entity was last modified.
        /// </summary>
        /// <returns>The last modification timestamp.</returns>
        DateTime ModifiedAt { get; }
    }
}