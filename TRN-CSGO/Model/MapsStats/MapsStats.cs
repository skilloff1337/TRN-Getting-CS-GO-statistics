using Newtonsoft.Json;

namespace TRN_CSGO.Model.MapsStats
{
    public class MapsStats
    {
        [JsonProperty("rounds")] public MapsStatInfo MapsStatInfo { get; set; }
        [JsonProperty("wins")] public MapsStatInfo Wins { get; set; }
    }
}