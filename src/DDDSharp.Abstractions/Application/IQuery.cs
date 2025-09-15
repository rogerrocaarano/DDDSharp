using System;

namespace DDDSharp.Abstractions.Application
{
    /// <summary>
    /// Represents a query that retrieves data from the application.
    /// </summary>
    /// <typeparam name="TResult">The type of result returned by the query.</typeparam>
    public interface IQuery<TResult>
    {
        /// <summary>
        /// Gets the unique identifier for this query.
        /// </summary>
        /// <returns>The query identifier.</returns>
        Guid Id { get; }

        /// <summary>
        /// Gets the date and time when this query was called.
        /// </summary>
        /// <returns>The timestamp when the query was invoked.</returns>
        DateTime CalledAt { get; }

        /// <summary>
        /// Validates the query to ensure it is in a valid state for execution.
        /// </summary>
        /// <exception cref="InvalidOperationException">Thrown when the query is in an invalid state.</exception>
        void Validate();
    }
}