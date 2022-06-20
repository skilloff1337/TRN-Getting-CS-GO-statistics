using Newtonsoft.Json;

namespace TRN_CSGO.Model.MapsStats
{
    public class MapsMetadata
    {
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("imageUrl")] public string ImageUrl { get; set; }
    }
}