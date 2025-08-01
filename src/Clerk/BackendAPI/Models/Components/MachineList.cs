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
    
    /// <summary>
    /// Success
    /// </summary>
    public class MachineList
    {

        [JsonProperty("data")]
        public List<Machine> Data { get; set; } = default!;

        /// <summary>
        /// Total number of machines
        /// </summary>
        [JsonProperty("total_count")]
        public long TotalCount { get; set; } = default!;
    }
}