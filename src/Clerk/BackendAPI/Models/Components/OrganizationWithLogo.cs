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
    
    public class OrganizationWithLogo
    {

        [JsonProperty("object")]
        public OrganizationWithLogoObject Object { get; set; } = default!;

        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        [JsonProperty("name")]
        public string Name { get; set; } = default!;

        [JsonProperty("slug")]
        public string Slug { get; set; } = default!;

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; } = default!;

        [JsonProperty("has_image")]
        public bool HasImage { get; set; } = default!;

        [JsonProperty("members_count")]
        public long? MembersCount { get; set; }

        [JsonProperty("missing_member_with_elevated_permissions")]
        public bool? MissingMemberWithElevatedPermissions { get; set; }

        [JsonProperty("pending_invitations_count")]
        public long? PendingInvitationsCount { get; set; }

        [JsonProperty("max_allowed_memberships")]
        public long MaxAllowedMemberships { get; set; } = default!;

        [JsonProperty("admin_delete_enabled")]
        public bool AdminDeleteEnabled { get; set; } = default!;

        [JsonProperty("public_metadata")]
        public Dictionary<string, object> PublicMetadata { get; set; } = default!;

        [JsonProperty("private_metadata")]
        public Dictionary<string, object>? PrivateMetadata { get; set; }

        [JsonProperty("created_by")]
        public string? CreatedBy { get; set; }

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

        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("logo_url")]
        public string? LogoUrl { get; set; }
    }
}