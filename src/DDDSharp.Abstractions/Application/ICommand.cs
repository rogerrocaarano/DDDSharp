using System;

namespace DDDSharp.Abstractions.Application
{
    /// <summary>
    /// Represents a command that performs an action within the application.
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Gets the unique identifier for this command.
        /// </summary>
        /// <returns>The command identifier.</returns>
        Guid Id { get; }

        /// <summary>
        /// Gets the date and time when this command was called.
        /// </summary>
        /// <returns>The timestamp when the command was invoked.</returns>
        DateTime CalledAt { get; }

        /// <summary>
        /// Validates the command to ensure it is in a valid state for execution.
        /// </summary>
        /// <exception cref="InvalidOperationException">Thrown when the command is in an invalid state.</exception>
        void Validate();
    }
}