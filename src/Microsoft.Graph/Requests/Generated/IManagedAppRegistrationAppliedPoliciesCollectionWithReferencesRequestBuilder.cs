// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IManagedAppRegistrationAppliedPoliciesCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial interface IManagedAppRegistrationAppliedPoliciesCollectionWithReferencesRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IManagedAppRegistrationAppliedPoliciesCollectionWithReferencesRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IManagedAppRegistrationAppliedPoliciesCollectionWithReferencesRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IManagedAppPolicyWithReferenceRequestBuilder"/> for the specified ManagedAppPolicy.
        /// </summary>
        /// <param name="id">The ID for the ManagedAppPolicy.</param>
        /// <returns>The <see cref="IManagedAppPolicyWithReferenceRequestBuilder"/>.</returns>
        IManagedAppPolicyWithReferenceRequestBuilder this[string id] { get; }
        
        /// <summary>
        /// Gets an <see cref="IManagedAppRegistrationAppliedPoliciesCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IManagedAppRegistrationAppliedPoliciesCollectionReferencesRequestBuilder"/>.</returns>
        IManagedAppRegistrationAppliedPoliciesCollectionReferencesRequestBuilder References { get; }

    }
}