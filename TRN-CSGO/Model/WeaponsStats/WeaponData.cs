using System;
using Newtonsoft.Json;

namespace TRN_CSGO.Model.WeaponsStats
{
    public class WeaponData
    {
        [JsonProperty("type")] public string Type { get; set; }
        [JsonProperty("attributes")] public WeaponAttributes WeaponAttributes { get; set; }
        [JsonProperty("metadata")] public WeaponMetadata WeaponMetadata { get; set; }
        [JsonProperty("expiryDate")] public DateTime ExpiryDate { get; set; }
        [JsonProperty("stats")] public WeaponStats WeaponStats { get; set; }
    }
}