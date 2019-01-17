// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DatabaseManager.cs" company="">
//   
// </copyright>
// <summary>
//   The database manager.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Rules.Manager
{
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Threading.Tasks;

    using Dapper;

    using Microsoft.Extensions.Configuration;

    using Rules.Dtos;

    /// <inheritdoc />
    public class DatabaseManager : IDatabaseManager
    {
        /// <summary>
        /// The conn.
        /// </summary>
        private readonly SqlConnection conn;

        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseManager"/> class.
        /// </summary>
        /// <param name="configuration">
        /// The configuration.
        /// </param>
        public DatabaseManager(IConfiguration configuration)
        {
            this.conn = new SqlConnection(configuration.GetConnectionString("Default"));
        }

        /// <inheritdoc />
        public Task<TicketsOutput> GetByIdAsync(long id, int maxRegisters)
        {
            return this.conn.QuerySingleOrDefaultAsync<TicketsOutput>("SUA QUERY");
        }

        /// <inheritdoc />
        public Task<IEnumerable<TicketsOutput>> GetCompletedAsync(int maxRegisters)
        {
            return this.conn.QueryAsync<TicketsOutput>("SUA QUERY");
        }

        /// <inheritdoc />
        public Task<IEnumerable<TicketsOutput>> GetCanceledAsync(int maxRegisters)
        {
            return this.conn.QueryAsync<TicketsOutput>("SUA QUERY");
        }

        /// <inheritdoc />
        public Task<IEnumerable<TicketsOutput>> GetOpenTicketsAsync(int maxRegisters)
        {
            return this.conn.QueryAsync<TicketsOutput>("SUA QUERY");
        }
    }
}
