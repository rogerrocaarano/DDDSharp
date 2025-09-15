using System.Collections.Generic;
using System.Threading.Tasks;
using DDDSharp.Abstractions.Domain;

namespace DDDSharp.Abstractions.Application
{
    /// <summary>
    /// Represents a publisher for domain events.
    /// </summary>
    public interface IEventPublisher
    {
        /// <summary>
        /// Publishes all specified domain events asynchronously.
        /// </summary>
        /// <param name="events">The collection of domain events to publish.</param>
        /// <returns>A task that represents the asynchronous publish operation.</returns>
        Task PublishAllAsync(IEnumerable<DomainEvent> events);
    }
}