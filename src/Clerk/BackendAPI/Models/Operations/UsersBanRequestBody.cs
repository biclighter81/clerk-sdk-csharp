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
    using System.Collections.Generic;
    
    public class UsersBanRequestBody
    {

        /// <summary>
        /// Array of user IDs to ban
        /// </summary>
        [JsonProperty("user_ids")]
        public List<string> UserIds { get; set; } = default!;
    }
}