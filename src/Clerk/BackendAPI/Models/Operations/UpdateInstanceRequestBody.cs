//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Clerk.BackendAPI.Models.Operations
{
    using Clerk.BackendAPI.Utils;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public class UpdateInstanceRequestBody
    {

        /// <summary>
        /// Toggles test mode for this instance, allowing the use of test email addresses and phone numbers.<br/>
        /// 
        /// <remarks>
        /// Defaults to true for development instances.
        /// </remarks>
        /// </summary>
        [JsonProperty("test_mode")]
        public bool? TestMode { get; set; } = null;

        /// <summary>
        /// Whether the instance should be using the HIBP service to check passwords for breaches
        /// </summary>
        [JsonProperty("hibp")]
        public bool? Hibp { get; set; } = null;

        /// <summary>
        /// The &quot;enhanced_email_deliverability&quot; feature will send emails from &quot;verifications@clerk.dev&quot; instead of your domain.<br/>
        /// 
        /// <remarks>
        /// This can be helpful if you do not have a high domain reputation.
        /// </remarks>
        /// </summary>
        [JsonProperty("enhanced_email_deliverability")]
        public bool? EnhancedEmailDeliverability { get; set; } = null;

        [JsonProperty("support_email")]
        public string? SupportEmail { get; set; } = null;

        [JsonProperty("clerk_js_version")]
        public string? ClerkJsVersion { get; set; } = null;

        [JsonProperty("development_origin")]
        public string? DevelopmentOrigin { get; set; } = null;

        /// <summary>
        /// For browser-like stacks such as browser extensions, Electron (not officially supported), or Capacitor.js (not officially supported), the instance allowed origins need to be updated with the request origin value. For Chrome extensions popup, background, or service worker pages, the origin is chrome-extension://extension_uuid. For Electron apps the default origin is http://localhost:3000. For Capacitor, the origin is capacitor://localhost.
        /// </summary>
        [JsonProperty("allowed_origins")]
        public List<string>? AllowedOrigins { get; set; }

        /// <summary>
        /// Whether the instance should operate in cookieless development mode (i.e. without third-party cookies).<br/>
        /// 
        /// <remarks>
        /// Deprecated: Please use `url_based_session_syncing` instead.
        /// </remarks>
        /// </summary>
        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("cookieless_dev")]
        public bool? CookielessDev { get; set; } = null;

        /// <summary>
        /// Whether the instance should use URL-based session syncing in development mode (i.e. without third-party cookies).
        /// </summary>
        [JsonProperty("url_based_session_syncing")]
        public bool? UrlBasedSessionSyncing { get; set; } = null;
    }
}