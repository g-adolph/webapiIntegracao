// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TicketsOutput.cs" company="">
//   
// </copyright>
// <summary>
//   The tickets output.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Rules.Dtos
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The tickets output.
    /// </summary>
    public class TicketsOutput
    {
        /// <summary>
        /// Gets or sets a value indicating whether HasConversation.
        /// </summary>
        public bool HasConversation { get; set; }

        /// <summary>
        /// Gets or sets the udf char 20.
        /// </summary>
        public string UdfChar20 { get; set; }

        /// <summary>
        /// Gets or sets the udf char 22.
        /// </summary>
        public string UdfChar22 { get; set; }

        /// <summary>
        /// Gets or sets the udf char 23.
        /// </summary>
        public string UdfChar23 { get; set; }

        /// <summary>
        /// Gets or sets the worker order id.
        /// </summary>
        public string WorkerOrderId { get; set; }

        /// <summary>
        /// Gets or sets the mode.
        /// </summary>
        public string Mode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether stop timer.
        /// </summary>
        public bool StopTimer { get; set; }

        /// <summary>
        /// Gets or sets the sla.
        /// </summary>
        public string Sla { get; set; }

        /// <summary>
        /// Gets or sets the priority.
        /// </summary>
        public string Priority { get; set; }

        /// <summary>
        /// Gets or sets the sub category.
        /// </summary>
        public string SubCategory { get; set; }

        /// <summary>
        /// Gets or sets the long request id.
        /// </summary>
        public string LongRequestId { get; set; }

        /// <summary>
        /// Gets or sets the udf char 29.
        /// </summary>
        public string UdfChar29 { get; set; }

        /// <summary>
        /// Gets or sets the group.
        /// </summary>
        public string Group { get; set; }

        /// <summary>
        /// Gets or sets the udf char 8.
        /// </summary>
        public string UdfChar8 { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the udf char 7.
        /// </summary>
        public string UdfChar7 { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether has attachments.
        /// </summary>
        public bool HasAttachments { get; set; }

        // TODO: Você irá precisar saber como será feita essa parte.

        /// <summary>
        /// Gets or sets the attachments.
        /// </summary>
        public List<byte[]> Attachments { get; set; }
    }
}
