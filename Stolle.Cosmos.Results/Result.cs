#region Header

// Created By: Jason Stolle
// 20191108
// StolleStolle.CosmosResult.cs

#endregion

#region Using

using System;

#endregion

namespace Stolle.Cosmos.Results
{
    /// <summary>
    ///     Result to return from an extension transaction
    /// </summary>
    public class Result : IResult
    {
        /// <summary>
        ///     Yes/no overall result
        /// </summary>
        public bool Success { get; set; } = false;

        /// <summary>
        ///     The message from the transaction
        /// </summary>
        public string Message { get; set; } = string.Empty;

        /// <summary>
        ///     The exception (if applicable)
        /// </summary>
        public Exception Exception { get; set; }
    }

    /// <summary>
    ///     Result to return from an extension transaction
    /// </summary>
    public class Result<TContent>
        : Result,
          IResult<TContent>
    {
        /// <summary>
        ///     Content from the transaction
        /// </summary>
        public TContent Content { get; set; }
    }
}