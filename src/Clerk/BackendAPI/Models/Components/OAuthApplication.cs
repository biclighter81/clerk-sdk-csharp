//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Clerk.BackendAPI.Models.Components
{
    using Clerk.BackendAPI.Models.Components;
    using Clerk.BackendAPI.Utils;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public class OAuthApplication
    {

        [JsonProperty("object")]
        public OAuthApplicationObject Object { get; set; } = default!;

        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        [JsonProperty("instance_id")]
        public string InstanceId { get; set; } = default!;

        [JsonProperty("name")]
        public string Name { get; set; } = default!;

        [JsonProperty("client_id")]
        public string ClientId { get; set; } = default!;

        [JsonProperty("client_uri", NullValueHandling = NullValueHandling.Include)]
        public string? ClientUri { get; set; }

        [JsonProperty("client_image_url", NullValueHandling = NullValueHandling.Include)]
        public string? ClientImageUrl { get; set; }

        [JsonProperty("dynamically_registered")]
        public bool DynamicallyRegistered { get; set; } = default!;

        [JsonProperty("consent_screen_enabled")]
        public bool ConsentScreenEnabled { get; set; } = default!;

        [JsonProperty("pkce_required")]
        public bool PkceRequired { get; set; } = default!;

        [JsonProperty("public")]
        public bool Public { get; set; } = default!;

        [JsonProperty("scopes")]
        public string Scopes { get; set; } = default!;

        [JsonProperty("redirect_uris")]
        public List<string> RedirectUris { get; set; } = default!;

        /// <summary>
        /// Deprecated: Use redirect_uris instead.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("callback_url")]
        public string CallbackUrl { get; set; } = default!;

        [JsonProperty("authorize_url")]
        public string AuthorizeUrl { get; set; } = default!;

        [JsonProperty("token_fetch_url")]
        public string TokenFetchUrl { get; set; } = default!;

        [JsonProperty("user_info_url")]
        public string UserInfoUrl { get; set; } = default!;

        [JsonProperty("discovery_url")]
        public string DiscoveryUrl { get; set; } = default!;

        [JsonProperty("token_introspection_url")]
        public string TokenIntrospectionUrl { get; set; } = default!;

        /// <summary>
        /// Unix timestamp of creation.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("created_at")]
        public long CreatedAt { get; set; } = default!;

        /// <summary>
        /// Unix timestamp of last update.<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("updated_at")]
        public long UpdatedAt { get; set; } = default!;
    }
}