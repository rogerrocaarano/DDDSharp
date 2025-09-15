using System.Threading;
using System.Threading.Tasks;

namespace DDDSharp.Abstractions.Application
{
    /// <summary>
    /// Represents a unit of work pattern for managing transactions and coordinating repository operations.
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// Commits all pending changes to the underlying data store asynchronously.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token to observe while waiting for the task to complete.</param>
        /// <returns>A task that represents the asynchronous commit operation. The task result contains the number of entities affected.</returns>
        Task<int> CommitAsync(CancellationToken cancellationToken = default);
    }
}