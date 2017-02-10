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
    /// The type WorkbookFunctionsBeta_InvRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookFunctionsBeta_InvRequestBody
    {
    
        /// <summary>
        /// Gets or sets Probability.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "probability", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken Probability { get; set; }
    
        /// <summary>
        /// Gets or sets Alpha.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "alpha", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken Alpha { get; set; }
    
        /// <summary>
        /// Gets or sets Beta.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "beta", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken Beta { get; set; }
    
        /// <summary>
        /// Gets or sets A.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "A", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken A { get; set; }
    
        /// <summary>
        /// Gets or sets B.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "B", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken B { get; set; }
    
    }
}
