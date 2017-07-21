// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum PeriodType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum PeriodType
    {
    
        /// <summary>
        /// d7
        /// </summary>
        D7 = 7,
	
        /// <summary>
        /// d30
        /// </summary>
        D30 = 30,
	
        /// <summary>
        /// d90
        /// </summary>
        D90 = 90,
	
        /// <summary>
        /// d180
        /// </summary>
        D180 = 180,
	
    }
}