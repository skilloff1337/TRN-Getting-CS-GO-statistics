using Newtonsoft.Json;

namespace TRN_CSGO.Model.ProfileStats
{
    public class Profile
    {
        [JsonProperty("data")] public ProfileData ProfileData { get; set; }
    }
}