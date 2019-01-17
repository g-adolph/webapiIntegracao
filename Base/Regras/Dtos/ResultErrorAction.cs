// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ResultErrorAction.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the ResultErrorAction type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Rules.Dtos
{
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// The result error action.
    /// </summary>
    public class ResultErrorAction : ActionResult
    {
        /// <summary>
        /// Gets or sets the result.
        /// </summary>
        public BaseResultErrorAction Result { get; set; }
    }
}