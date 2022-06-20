using System.Collections.Generic;
using Newtonsoft.Json;

namespace TRN_CSGO.Model.MapsStats
{
    public class Maps
    {
        [JsonProperty("data")] public List<MapsData> Data { get; set; }
    }
}