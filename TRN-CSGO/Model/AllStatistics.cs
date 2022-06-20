using TRN_CSGO.Model.MapsStats;
using TRN_CSGO.Model.ProfileStats;
using TRN_CSGO.Model.WeaponsStats;

namespace TRN_CSGO.Model
{
    public class AllStatistics
    {
        public Maps Map { get; set; }
        public Profile Profile { get; set; }
        public Weapon Weapon { get; set; }
    }
}