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
    /// The type Android Eas Email Profile Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AndroidEasEmailProfileConfiguration : DeviceConfiguration
    {
    
        /// <summary>
        /// Gets or sets account name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accountName", Required = Newtonsoft.Json.Required.Default)]
        public string AccountName { get; set; }
    
        /// <summary>
        /// Gets or sets authentication method.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "authenticationMethod", Required = Newtonsoft.Json.Required.Default)]
        public EasAuthenticationMethod? AuthenticationMethod { get; set; }
    
        /// <summary>
        /// Gets or sets sync calendar.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "syncCalendar", Required = Newtonsoft.Json.Required.Default)]
        public bool? SyncCalendar { get; set; }
    
        /// <summary>
        /// Gets or sets sync contacts.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "syncContacts", Required = Newtonsoft.Json.Required.Default)]
        public bool? SyncContacts { get; set; }
    
        /// <summary>
        /// Gets or sets sync tasks.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "syncTasks", Required = Newtonsoft.Json.Required.Default)]
        public bool? SyncTasks { get; set; }
    
        /// <summary>
        /// Gets or sets sync notes.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "syncNotes", Required = Newtonsoft.Json.Required.Default)]
        public bool? SyncNotes { get; set; }
    
        /// <summary>
        /// Gets or sets duration of email to sync.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "durationOfEmailToSync", Required = Newtonsoft.Json.Required.Default)]
        public EmailSyncDuration? DurationOfEmailToSync { get; set; }
    
        /// <summary>
        /// Gets or sets email address source.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "emailAddressSource", Required = Newtonsoft.Json.Required.Default)]
        public UserEmailSource? EmailAddressSource { get; set; }
    
        /// <summary>
        /// Gets or sets email sync schedule.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "emailSyncSchedule", Required = Newtonsoft.Json.Required.Default)]
        public EmailSyncSchedule? EmailSyncSchedule { get; set; }
    
        /// <summary>
        /// Gets or sets host name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hostName", Required = Newtonsoft.Json.Required.Default)]
        public string HostName { get; set; }
    
        /// <summary>
        /// Gets or sets require smime.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "requireSmime", Required = Newtonsoft.Json.Required.Default)]
        public bool? RequireSmime { get; set; }
    
        /// <summary>
        /// Gets or sets require ssl.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "requireSsl", Required = Newtonsoft.Json.Required.Default)]
        public bool? RequireSsl { get; set; }
    
        /// <summary>
        /// Gets or sets username source.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "usernameSource", Required = Newtonsoft.Json.Required.Default)]
        public AndroidUsernameSource? UsernameSource { get; set; }
    
        /// <summary>
        /// Gets or sets identity certificate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "identityCertificate", Required = Newtonsoft.Json.Required.Default)]
        public AndroidCertificateProfileBase IdentityCertificate { get; set; }
    
        /// <summary>
        /// Gets or sets smime signing certificate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "smimeSigningCertificate", Required = Newtonsoft.Json.Required.Default)]
        public AndroidCertificateProfileBase SmimeSigningCertificate { get; set; }
    
    }
}
