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
    using System.Collections.Generic;
    
    public class ManagementCreateApplicationRequest
    {

        /// <summary>
        /// The name of the application.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The owner ID (organization ID) of the application.
        /// </summary>
        [JsonProperty("owner_id")]
        public string OwnerId { get; set; } = default!;

        /// <summary>
        /// The plan ID for the application (e.g., &quot;free_2022_06&quot;, &quot;pro_2023_11&quot;).
        /// </summary>
        [JsonProperty("plan_id")]
        public string PlanId { get; set; } = default!;

        /// <summary>
        /// List of add-on IDs (e.g., [&quot;enhanced_auth_2023_11&quot;, &quot;enhanced_orgs_2023_11&quot;]).
        /// </summary>
        [JsonProperty("addon_ids")]
        public List<string>? AddonIds { get; set; }

        /// <summary>
        /// Whether the application is paid externally.
        /// </summary>
        [JsonProperty("paid_externally")]
        public bool? PaidExternally { get; set; }

        /// <summary>
        /// Whether the application is in test mode.
        /// </summary>
        [JsonProperty("test_mode")]
        public bool? TestMode { get; set; }

        /// <summary>
        /// Maximum allowed users for the application.
        /// </summary>
        [JsonProperty("max_allowed_users")]
        public long? MaxAllowedUsers { get; set; }

        /// <summary>
        /// Maximum allowed organizations for the application.
        /// </summary>
        [JsonProperty("max_allowed_organizations")]
        public long? MaxAllowedOrganizations { get; set; }

        /// <summary>
        /// Subscription metadata for the application.
        /// </summary>
        [JsonProperty("subscription_metadata")]
        public Dictionary<string, string>? SubscriptionMetadata { get; set; }

        /// <summary>
        /// List of environment types to create instances for.
        /// </summary>
        [JsonProperty("environment_types")]
        public List<EnvironmentTypes>? EnvironmentTypes { get; set; }
    }
}