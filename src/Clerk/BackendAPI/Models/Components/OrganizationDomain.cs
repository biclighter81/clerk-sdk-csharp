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
    
    /// <summary>
    /// An organization domain
    /// </summary>
    public class OrganizationDomain
    {

        /// <summary>
        /// String representing the object&apos;s type. Objects of the same type share the same value. Always `organization_domain`<br/>
        /// 
        /// <remarks>
        /// 
        /// </remarks>
        /// </summary>
        [JsonProperty("object")]
        public OrganizationDomainObject Object { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the organization domain
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the organization
        /// </summary>
        [JsonProperty("organization_id")]
        public string OrganizationId { get; set; } = default!;

        /// <summary>
        /// Name of the organization domain
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Mode of enrollment for the domain
        /// </summary>
        [JsonProperty("enrollment_mode")]
        public Models.Components.EnrollmentMode EnrollmentMode { get; set; } = default!;

        /// <summary>
        /// Affiliation email address for the domain, if available.
        /// </summary>
        [JsonProperty("affiliation_email_address", NullValueHandling = NullValueHandling.Include)]
        public string? AffiliationEmailAddress { get; set; }

        /// <summary>
        /// Verification details for the domain
        /// </summary>
        [JsonProperty("verification", NullValueHandling = NullValueHandling.Include)]
        public OrganizationDomainVerification? Verification { get; set; }

        /// <summary>
        /// Total number of pending invitations associated with this domain
        /// </summary>
        [JsonProperty("total_pending_invitations")]
        public int TotalPendingInvitations { get; set; } = default!;

        /// <summary>
        /// Total number of pending suggestions associated with this domain
        /// </summary>
        [JsonProperty("total_pending_suggestions")]
        public int TotalPendingSuggestions { get; set; } = default!;

        /// <summary>
        /// Unix timestamp when the domain was created
        /// </summary>
        [JsonProperty("created_at")]
        public long CreatedAt { get; set; } = default!;

        /// <summary>
        /// Unix timestamp of the last update to the domain
        /// </summary>
        [JsonProperty("updated_at")]
        public long UpdatedAt { get; set; } = default!;
    }
}