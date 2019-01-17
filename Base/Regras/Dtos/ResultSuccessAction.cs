// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ResultSuccessAction.cs" company="">
//   
// </copyright>
// <summary>
//   The result action.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Rules.Dtos
{
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// The result success action.
    /// </summary>
    /// <typeparam name="TType">
    /// Type of Result Class
    /// </typeparam>
    public class ResultSuccessAction<TType>
        where TType : class
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessAction{TType}"/> class.
        /// </summary>
        public ResultSuccessAction()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessAction{TType}"/> class.
        /// </summary>
        /// <param name="details">
        /// The details.
        /// </param>
        public ResultSuccessAction(TType details)
        {
            this.Details = details;
        }

        /// <summary>
        /// Gets or sets the result.
        /// </summary>
        public BaseResultAction Result { get; set; } = new BaseResultAction();

        /// <summary>
        /// Gets or sets the details.
        /// </summary>
        public TType Details { get; set; }
    }
}
