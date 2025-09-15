using System;
using System.Threading.Tasks;
using DDDSharp.Abstractions.Domain;

namespace DDDSharp.Abstractions.Application
{
    /// <summary>
    /// Represents a repository for aggregate root entities.
    /// </summary>
    /// <typeparam name="TAggregate">The type of aggregate root.</typeparam>
    public interface IRepository<TAggregate> where TAggregate : AggregateRoot
    {
        /// <summary>
        /// Retrieves an aggregate by its unique identifier asynchronously.
        /// </summary>
        /// <param name="id">The unique identifier of the aggregate.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the aggregate if found; otherwise, null.</returns>
        Task<TAggregate?> GetByIdAsync(Guid id);

        /// <summary>
        /// Adds a new aggregate to the repository asynchronously.
        /// </summary>
        /// <param name="aggregate">The aggregate to add.</param>
        /// <returns>A task that represents the asynchronous add operation.</returns>
        Task AddAsync(TAggregate aggregate);

        /// <summary>
        /// Updates an existing aggregate in the repository asynchronously.
        /// </summary>
        /// <param name="aggregate">The aggregate to update.</param>
        /// <returns>A task that represents the asynchronous update operation.</returns>
        Task UpdateAsync(TAggregate aggregate);

        /// <summary>
        /// Removes an aggregate from the repository asynchronously.
        /// </summary>
        /// <param name="aggregate">The aggregate to remove.</param>
        /// <returns>A task that represents the asynchronous remove operation.</returns>
        Task RemoveAsync(TAggregate aggregate);
    }
}