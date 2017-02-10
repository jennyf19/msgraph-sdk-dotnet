// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ISharedDriveItemRequest.
    /// </summary>
    public partial interface ISharedDriveItemRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SharedDriveItem using PUT.
        /// </summary>
        /// <param name="sharedDriveItemToCreate">The SharedDriveItem to create.</param>
        /// <returns>The created SharedDriveItem.</returns>
        System.Threading.Tasks.Task<SharedDriveItem> CreateAsync(SharedDriveItem sharedDriveItemToCreate);        /// <summary>
        /// Creates the specified SharedDriveItem using PUT.
        /// </summary>
        /// <param name="sharedDriveItemToCreate">The SharedDriveItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SharedDriveItem.</returns>
        System.Threading.Tasks.Task<SharedDriveItem> CreateAsync(SharedDriveItem sharedDriveItemToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified SharedDriveItem.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified SharedDriveItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified SharedDriveItem.
        /// </summary>
        /// <returns>The SharedDriveItem.</returns>
        System.Threading.Tasks.Task<SharedDriveItem> GetAsync();

        /// <summary>
        /// Gets the specified SharedDriveItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SharedDriveItem.</returns>
        System.Threading.Tasks.Task<SharedDriveItem> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified SharedDriveItem using PATCH.
        /// </summary>
        /// <param name="sharedDriveItemToUpdate">The SharedDriveItem to update.</param>
        /// <returns>The updated SharedDriveItem.</returns>
        System.Threading.Tasks.Task<SharedDriveItem> UpdateAsync(SharedDriveItem sharedDriveItemToUpdate);

        /// <summary>
        /// Updates the specified SharedDriveItem using PATCH.
        /// </summary>
        /// <param name="sharedDriveItemToUpdate">The SharedDriveItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated SharedDriveItem.</returns>
        System.Threading.Tasks.Task<SharedDriveItem> UpdateAsync(SharedDriveItem sharedDriveItemToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISharedDriveItemRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISharedDriveItemRequest Expand(Expression<Func<SharedDriveItem, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISharedDriveItemRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISharedDriveItemRequest Select(Expression<Func<SharedDriveItem, object>> selectExpression);

    }
}
