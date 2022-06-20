using Newtonsoft.Json;

namespace TRN_CSGO.Model.ProfileStats
{
    public class ProfileMetadata
    {
        [JsonProperty("name")] public string Name { get; set; }
    }
}