using System;

namespace DDDSharp.Abstractions.Domain
{
    /// <summary>
    /// Represents a base entity with a unique identifier.
    /// </summary>
    public abstract class Entity
    {
        /// <summary>
        /// Gets the unique identifier for this entity.
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Initializes a new instance of the Entity class.
        /// </summary>
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        /// <summary>
        /// Initializes a new instance of the Entity class with a specific identifier.
        /// </summary>
        /// <param name="id">The unique identifier for this entity.</param>
        protected Entity(Guid id)
        {
            Id = id;
        }
    }
}