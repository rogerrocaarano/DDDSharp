using System;

namespace DDDSharp.Abstractions.Domain
{
    /// <summary>
    /// Represents a base domain event that occurs within the domain.
    /// </summary>
    public abstract class DomainEvent
    {
        /// <summary>
        /// Gets the unique identifier for this event.
        /// </summary>
        protected Guid EventId { get; }

        /// <summary>
        /// Gets the identifier of the aggregate that raised this event.
        /// </summary>
        protected Guid AggregateId { get; }

        /// <summary>
        /// Gets the date and time when this event occurred.
        /// </summary>
        protected DateTime OccurredOn { get; }

        /// <summary>
        /// Initializes a new instance of the DomainEvent class.
        /// </summary>
        /// <param name="aggregateId">The identifier of the aggregate that raises this event.</param>
        protected DomainEvent(Guid aggregateId)
        {
            EventId = Guid.NewGuid();
            AggregateId = aggregateId;
            OccurredOn = DateTime.UtcNow;
        }

        /// <summary>
        /// Gets the unique identifier for this event.
        /// </summary>
        /// <returns>The event identifier.</returns>
        public Guid GetEventId() => EventId;

        /// <summary>
        /// Gets the date and time when this event occurred.
        /// </summary>
        /// <returns>The occurrence timestamp.</returns>
        public DateTime GetOccurredOn() => OccurredOn;

        /// <summary>
        /// Gets the identifier of the aggregate that raised this event.
        /// </summary>
        /// <returns>The aggregate identifier.</returns>
        public Guid GetAggregateId() => AggregateId;
    }
}