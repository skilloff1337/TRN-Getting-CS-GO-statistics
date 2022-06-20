using Newtonsoft.Json;

namespace TRN_CSGO.Model.WeaponsStats
{
    public class WeaponAttributes
    {
        [JsonProperty("key")] public string Key { get; set; }
        [JsonProperty("categoryKey")] public string CategoryKey { get; set; }
    }
}