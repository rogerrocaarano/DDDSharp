using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DDDSharp.Abstractions.Domain
{
    /// <summary>
    /// Represents an aggregate root entity that manages domain events and implements auditing.
    /// </summary>
    public abstract class AggregateRoot : Entity, IAuditable
    {
        private readonly List<DomainEvent> _domainEvents = new List<DomainEvent>();

        /// <summary>
        /// Gets the date and time when the aggregate was created.
        /// </summary>
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Gets the date and time when the aggregate was last modified.
        /// </summary>
        public DateTime ModifiedAt { get; private set; }

        /// <summary>
        /// Initializes a new instance of the AggregateRoot class.
        /// </summary>
        protected AggregateRoot() : base()
        {
            CreatedAt = DateTime.UtcNow;
            ModifiedAt = DateTime.UtcNow;
        }

        /// <summary>
        /// Initializes a new instance of the AggregateRoot class with a specific identifier.
        /// </summary>
        /// <param name="id">The unique identifier for this aggregate.</param>
        protected AggregateRoot(Guid id) : base(id)
        {
            CreatedAt = DateTime.UtcNow;
            ModifiedAt = DateTime.UtcNow;
        }

        /// <summary>
        /// Initializes a new instance of the AggregateRoot class with specific timestamps.
        /// </summary>
        protected AggregateRoot(Guid id, DateTime createdAt, DateTime modifiedAt)
        : base(id)
        {
            CreatedAt = createdAt;
            ModifiedAt = modifiedAt;
        }

        /// <summary>
        /// Gets a read-only collection of domain events associated with this aggregate.
        /// </summary>
        /// <returns>A read-only collection of domain events.</returns>
        public ReadOnlyCollection<DomainEvent> DomainEvents()
        {
            return _domainEvents.AsReadOnly();
        }

        /// <summary>
        /// Adds a domain event to the aggregate.
        /// </summary>
        /// <param name="domainDomainEvent">The domain event to add.</param>
        protected void AddDomainEvent(DomainEvent domainDomainEvent)
        {
            if (domainDomainEvent == null)
                throw new ArgumentNullException(nameof(domainDomainEvent));

            _domainEvents.Add(domainDomainEvent);
            ModifiedAt = DateTime.UtcNow;
        }

        /// <summary>
        /// Clears all domain events from the aggregate.
        /// </summary>
        public void ClearDomainEvents()
        {
            _domainEvents.Clear();
        }

        /// <summary>
        /// Updates the ModifiedAt timestamp to the current UTC time.
        /// </summary>
        protected void UpdateModifiedAt()
        {
            ModifiedAt = DateTime.UtcNow;
        }
    }
}