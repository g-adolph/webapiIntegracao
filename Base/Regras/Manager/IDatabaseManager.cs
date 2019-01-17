// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDatabaseManager.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the IDatabaseManager type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Rules.Manager
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Rules.Dtos;

    /// <summary>
    /// The DatabaseManager interface.
    /// </summary>
    public interface IDatabaseManager
    {
        /// <summary>
        /// Get ticket by id async.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <param name="maxRegisters">
        /// The max registers.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<TicketsOutput> GetByIdAsync(long id, int maxRegisters);

        /// <summary>
        /// Get canceled tickets async.
        /// </summary>
        /// <param name="maxRegisters">
        /// The max registers.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<IEnumerable<TicketsOutput>> GetCompletedAsync(int maxRegisters);

        /// <summary>
        /// Get canceled tickets async.
        /// </summary>
        /// <param name="maxRegisters">
        /// The max registers.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<IEnumerable<TicketsOutput>> GetCanceledAsync(int maxRegisters);
        
        /// <summary>
        /// Get open tickets async.
        /// </summary>
        /// <param name="maxRegisters">
        /// The max registers.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<IEnumerable<TicketsOutput>> GetOpenTicketsAsync(int maxRegisters);
    }
}