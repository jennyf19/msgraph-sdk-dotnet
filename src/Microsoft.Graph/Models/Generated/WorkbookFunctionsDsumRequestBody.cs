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
    /// The type WorkbookFunctionsDsumRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookFunctionsDsumRequestBody
    {
    
        /// <summary>
        /// Gets or sets Database.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "database", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken Database { get; set; }
    
        /// <summary>
        /// Gets or sets Field.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "field", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken Field { get; set; }
    
        /// <summary>
        /// Gets or sets Criteria.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "criteria", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken Criteria { get; set; }
    
    }
}
