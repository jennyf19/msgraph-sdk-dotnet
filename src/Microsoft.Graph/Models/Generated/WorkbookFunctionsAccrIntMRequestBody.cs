// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type WorkbookFunctionsAccrIntMRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookFunctionsAccrIntMRequestBody
    {
    
        /// <summary>
        /// Gets or sets Issue.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "issue", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken Issue { get; set; }
    
        /// <summary>
        /// Gets or sets Settlement.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settlement", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken Settlement { get; set; }
    
        /// <summary>
        /// Gets or sets Rate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "rate", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken Rate { get; set; }
    
        /// <summary>
        /// Gets or sets Par.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "par", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken Par { get; set; }
    
        /// <summary>
        /// Gets or sets Basis.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "basis", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken Basis { get; set; }
    
    }
}
