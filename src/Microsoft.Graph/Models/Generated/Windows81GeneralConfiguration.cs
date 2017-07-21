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
    /// The type Windows81General Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Windows81GeneralConfiguration : DeviceConfiguration
    {
    
        /// <summary>
        /// Gets or sets accounts block adding non microsoft account email.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accountsBlockAddingNonMicrosoftAccountEmail", Required = Newtonsoft.Json.Required.Default)]
        public bool? AccountsBlockAddingNonMicrosoftAccountEmail { get; set; }
    
        /// <summary>
        /// Gets or sets apply only to windows81.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applyOnlyToWindows81", Required = Newtonsoft.Json.Required.Default)]
        public bool? ApplyOnlyToWindows81 { get; set; }
    
        /// <summary>
        /// Gets or sets browser block autofill.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "browserBlockAutofill", Required = Newtonsoft.Json.Required.Default)]
        public bool? BrowserBlockAutofill { get; set; }
    
        /// <summary>
        /// Gets or sets browser block automatic detection of intranet sites.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "browserBlockAutomaticDetectionOfIntranetSites", Required = Newtonsoft.Json.Required.Default)]
        public bool? BrowserBlockAutomaticDetectionOfIntranetSites { get; set; }
    
        /// <summary>
        /// Gets or sets browser block enterprise mode access.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "browserBlockEnterpriseModeAccess", Required = Newtonsoft.Json.Required.Default)]
        public bool? BrowserBlockEnterpriseModeAccess { get; set; }
    
        /// <summary>
        /// Gets or sets browser block java script.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "browserBlockJavaScript", Required = Newtonsoft.Json.Required.Default)]
        public bool? BrowserBlockJavaScript { get; set; }
    
        /// <summary>
        /// Gets or sets browser block plugins.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "browserBlockPlugins", Required = Newtonsoft.Json.Required.Default)]
        public bool? BrowserBlockPlugins { get; set; }
    
        /// <summary>
        /// Gets or sets browser block popups.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "browserBlockPopups", Required = Newtonsoft.Json.Required.Default)]
        public bool? BrowserBlockPopups { get; set; }
    
        /// <summary>
        /// Gets or sets browser block sending do not track header.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "browserBlockSendingDoNotTrackHeader", Required = Newtonsoft.Json.Required.Default)]
        public bool? BrowserBlockSendingDoNotTrackHeader { get; set; }
    
        /// <summary>
        /// Gets or sets browser block single word entry on intranet sites.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "browserBlockSingleWordEntryOnIntranetSites", Required = Newtonsoft.Json.Required.Default)]
        public bool? BrowserBlockSingleWordEntryOnIntranetSites { get; set; }
    
        /// <summary>
        /// Gets or sets browser require smart screen.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "browserRequireSmartScreen", Required = Newtonsoft.Json.Required.Default)]
        public bool? BrowserRequireSmartScreen { get; set; }
    
        /// <summary>
        /// Gets or sets browser enterprise mode site list location.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "browserEnterpriseModeSiteListLocation", Required = Newtonsoft.Json.Required.Default)]
        public string BrowserEnterpriseModeSiteListLocation { get; set; }
    
        /// <summary>
        /// Gets or sets browser internet security level.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "browserInternetSecurityLevel", Required = Newtonsoft.Json.Required.Default)]
        public InternetSiteSecurityLevel? BrowserInternetSecurityLevel { get; set; }
    
        /// <summary>
        /// Gets or sets browser intranet security level.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "browserIntranetSecurityLevel", Required = Newtonsoft.Json.Required.Default)]
        public SiteSecurityLevel? BrowserIntranetSecurityLevel { get; set; }
    
        /// <summary>
        /// Gets or sets browser logging report location.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "browserLoggingReportLocation", Required = Newtonsoft.Json.Required.Default)]
        public string BrowserLoggingReportLocation { get; set; }
    
        /// <summary>
        /// Gets or sets browser require high security for restricted sites.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "browserRequireHighSecurityForRestrictedSites", Required = Newtonsoft.Json.Required.Default)]
        public bool? BrowserRequireHighSecurityForRestrictedSites { get; set; }
    
        /// <summary>
        /// Gets or sets browser require firewall.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "browserRequireFirewall", Required = Newtonsoft.Json.Required.Default)]
        public bool? BrowserRequireFirewall { get; set; }
    
        /// <summary>
        /// Gets or sets browser require fraud warning.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "browserRequireFraudWarning", Required = Newtonsoft.Json.Required.Default)]
        public bool? BrowserRequireFraudWarning { get; set; }
    
        /// <summary>
        /// Gets or sets browser trusted sites security level.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "browserTrustedSitesSecurityLevel", Required = Newtonsoft.Json.Required.Default)]
        public SiteSecurityLevel? BrowserTrustedSitesSecurityLevel { get; set; }
    
        /// <summary>
        /// Gets or sets cellular block data roaming.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cellularBlockDataRoaming", Required = Newtonsoft.Json.Required.Default)]
        public bool? CellularBlockDataRoaming { get; set; }
    
        /// <summary>
        /// Gets or sets diagnostics block data submission.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "diagnosticsBlockDataSubmission", Required = Newtonsoft.Json.Required.Default)]
        public bool? DiagnosticsBlockDataSubmission { get; set; }
    
        /// <summary>
        /// Gets or sets password block picture password and pin.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordBlockPicturePasswordAndPin", Required = Newtonsoft.Json.Required.Default)]
        public bool? PasswordBlockPicturePasswordAndPin { get; set; }
    
        /// <summary>
        /// Gets or sets password expiration days.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordExpirationDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordExpirationDays { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum length.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinimumLength", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinimumLength { get; set; }
    
        /// <summary>
        /// Gets or sets password minutes of inactivity before screen timeout.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinutesOfInactivityBeforeScreenTimeout", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinutesOfInactivityBeforeScreenTimeout { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum character set count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinimumCharacterSetCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinimumCharacterSetCount { get; set; }
    
        /// <summary>
        /// Gets or sets password previous password block count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordPreviousPasswordBlockCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordPreviousPasswordBlockCount { get; set; }
    
        /// <summary>
        /// Gets or sets password required type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordRequiredType", Required = Newtonsoft.Json.Required.Default)]
        public RequiredPasswordType? PasswordRequiredType { get; set; }
    
        /// <summary>
        /// Gets or sets password sign in failure count before factory reset.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordSignInFailureCountBeforeFactoryReset", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordSignInFailureCountBeforeFactoryReset { get; set; }
    
        /// <summary>
        /// Gets or sets storage require device encryption.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "storageRequireDeviceEncryption", Required = Newtonsoft.Json.Required.Default)]
        public bool? StorageRequireDeviceEncryption { get; set; }
    
        /// <summary>
        /// Gets or sets minimum auto install classification.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimumAutoInstallClassification", Required = Newtonsoft.Json.Required.Default)]
        public UpdateClassification? MinimumAutoInstallClassification { get; set; }
    
        /// <summary>
        /// Gets or sets updates require automatic updates.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "updatesRequireAutomaticUpdates", Required = Newtonsoft.Json.Required.Default)]
        public bool? UpdatesRequireAutomaticUpdates { get; set; }
    
        /// <summary>
        /// Gets or sets user account control settings.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userAccountControlSettings", Required = Newtonsoft.Json.Required.Default)]
        public WindowsUserAccountControlSettings? UserAccountControlSettings { get; set; }
    
        /// <summary>
        /// Gets or sets work folders url.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "workFoldersUrl", Required = Newtonsoft.Json.Required.Default)]
        public string WorkFoldersUrl { get; set; }
    
    }
}
