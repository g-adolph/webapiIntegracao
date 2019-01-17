// --------------------------------------------------------------------------------------------------------------------
// <copyright file="V1Controller.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the V1Controller type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace WebApiIntegracao.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    using Rules.Dtos;
    using Rules.Manager;

    /// <inheritdoc />
    /// <summary>
    /// Controller V1
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class V1Controller : ControllerBase
    {
        /// <summary>
        /// The manager.
        /// </summary>
        private readonly IDatabaseManager manager;

        /// <summary>
        /// Initializes a new instance of the <see cref="V1Controller"/> class.
        /// </summary>
        /// <param name="manager">
        /// The manager.
        /// </param>
        public V1Controller(IDatabaseManager manager)
        {
            this.manager = manager;
        }
        
        /// <summary>
        /// The get by id.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <param name="maxRegisters">
        /// The max Registers.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        [HttpPost("{id}/{maxRegisters}")]
        public async Task<ActionResult<ResultSuccessAction<TicketsOutput>>> GetById(long id, int maxRegisters)
        {
            try
            {
                return new ResultSuccessAction<TicketsOutput>(
                    await this.manager.GetByIdAsync(id, maxRegisters).ConfigureAwait(false));
            }
            catch (Exception)
            {
                return new ResultErrorAction();
            }
        }

        /// <summary>
        /// The open.
        /// </summary>
        /// <param name="maxRegisters">
        /// The max registers.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        [HttpPost("open/{maxRegisters}")]
        public async Task<ActionResult<ResultSuccessAction<IEnumerable<TicketsOutput>>>> Open(int maxRegisters)
        {
            // TODO: Sua Logica vai aqui.
            try
            {
                return new ResultSuccessAction<IEnumerable<TicketsOutput>>(await this.manager.GetOpenTicketsAsync(maxRegisters).ConfigureAwait(false));
            }
            catch (Exception)
            {
                return new ResultErrorAction();
            }
        }

        /// <summary>
        /// The canceled.
        /// </summary>
        /// <param name="maxRegisters">
        /// The max registers.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        [HttpPost("canceled/{maxRegisters}")]
        public async Task<ActionResult<ResultSuccessAction<IEnumerable<TicketsOutput>>>> Canceled(int maxRegisters)
        {
            // TODO: Sua Logica vai aqui.
            try
            {
                return new ResultSuccessAction<IEnumerable<TicketsOutput>>(await this.manager.GetCanceledAsync(maxRegisters).ConfigureAwait(false));
            }
            catch (Exception)
            {
                return new ResultErrorAction();
            }
        }

        /// <summary>
        /// The completed.
        /// </summary>
        /// <param name="maxRegisters">
        /// The max registers.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        [HttpPost("completed/{maxRegisters}")]
        public async Task<ActionResult<ResultSuccessAction<IEnumerable<TicketsOutput>>>> Completed(int maxRegisters)
        {
            // TODO: Sua Logica vai aqui.
            try
            {
                return new ResultSuccessAction<IEnumerable<TicketsOutput>>(await this.manager.GetCompletedAsync(maxRegisters).ConfigureAwait(false));
            }
            catch (Exception)
            {
                return new ResultErrorAction();
            }
        }
    }
}
