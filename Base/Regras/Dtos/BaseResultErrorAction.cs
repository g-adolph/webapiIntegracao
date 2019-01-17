// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseResultErrorAction.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the BaseResultErrorAction type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Rules.Dtos
{
    /// <inheritdoc />
    /// <summary>
    /// The base result error action.
    /// </summary>
    public class BaseResultErrorAction : BaseResultAction
    {
        /// <summary>
        /// Gets or sets the input field.
        /// </summary>
        public string InputField { get; set; }

        /// <summary>
        /// Gets or sets the error code.
        /// </summary>
        public int ErrorCode { get; set; }
    }
}