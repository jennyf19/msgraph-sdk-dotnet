// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Android Managed App Protection.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AndroidManagedAppProtection : TargetedManagedAppProtection
    {
    
        /// <summary>
        /// Gets or sets screen capture blocked.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "screenCaptureBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? ScreenCaptureBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets encrypt app data.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "encryptAppData", Required = Newtonsoft.Json.Required.Default)]
        public bool? EncryptAppData { get; set; }
    
        /// <summary>
        /// Gets or sets deployed app count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deployedAppCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? DeployedAppCount { get; set; }
    
        /// <summary>
        /// Gets or sets mobile app identifier deployments.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mobileAppIdentifierDeployments", Required = Newtonsoft.Json.Required.Default)]
        public IAndroidManagedAppProtectionMobileAppIdentifierDeploymentsCollectionPage MobileAppIdentifierDeployments { get; set; }
    
        /// <summary>
        /// Gets or sets deployment summary.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deploymentSummary", Required = Newtonsoft.Json.Required.Default)]
        public ManagedAppPolicyDeploymentSummary DeploymentSummary { get; set; }
    
    }
}
