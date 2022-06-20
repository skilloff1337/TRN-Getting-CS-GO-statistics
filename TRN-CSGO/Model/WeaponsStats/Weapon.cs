using System.Collections.Generic;
using Newtonsoft.Json;

namespace TRN_CSGO.Model.WeaponsStats
{
    public class Weapon
    {
        [JsonProperty("data")] public List<WeaponData> Data { get; set; }
    }
}