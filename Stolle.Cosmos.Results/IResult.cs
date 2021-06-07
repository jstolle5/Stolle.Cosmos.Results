#region Header

// Created By: Jason Stolle
// 20191108
// StolleStolle.CosmosIResult.cs

#endregion

#region Using

using System;

#endregion

namespace Stolle.Cosmos.Results
{
    /// <summary>
    ///     Result to return from a transaction
    /// </summary>
    public interface IResult
    {
        /// <summary>
        ///     Yes/no overall result
        /// </summary>
        bool Success { get; set; }

        /// <summary>
        ///     The message from the transaction
        /// </summary>
        string Message { get; set; }

        /// <summary>
        ///     The exception (if applicable)
        /// </summary>
        Exception Exception { get; set; }
    }

    /// <summary>
    ///     Result to return from a  transaction with content
    /// </summary>
    public interface IResult<TContent> : IResult
    {
        /// <summary>
        ///     Content from the transaction
        /// </summary>
        TContent Content { get; set; }
    }
}