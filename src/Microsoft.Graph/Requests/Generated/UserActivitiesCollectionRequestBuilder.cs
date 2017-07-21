// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type UserActivitiesCollectionRequestBuilder.
    /// </summary>
    public partial class UserActivitiesCollectionRequestBuilder : BaseRequestBuilder, IUserActivitiesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new UserActivitiesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public UserActivitiesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IUserActivitiesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IUserActivitiesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new UserActivitiesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IActivityRequestBuilder"/> for the specified UserActivity.
        /// </summary>
        /// <param name="id">The ID for the UserActivity.</param>
        /// <returns>The <see cref="IActivityRequestBuilder"/>.</returns>
        public IActivityRequestBuilder this[string id]
        {
            get
            {
                return new ActivityRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}