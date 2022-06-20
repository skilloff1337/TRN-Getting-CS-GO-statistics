using System;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using TRN_CSGO.Model;
using TRN_CSGO.Model.MapsStats;
using TRN_CSGO.Model.ProfileStats;
using TRN_CSGO.Model.WeaponsStats;

namespace TRN_CSGO
{
    public class Program
    {
        private const string URL_CSGO = "https://public-api.tracker.gg/v2/csgo/standard/profile/steam/76561197965163731";
        private const string URL_CSGO_MAP = "https://public-api.tracker.gg/v2/csgo/standard/profile/steam/76561197965163731/segments/map";
        private const string URL_CSGO_WEAPON = "https://public-api.tracker.gg/v2/csgo/standard/profile/steam/76561197965163731/segments/weapon";
        private const string API_KEY = "YOUR API KEY!!!!!";

        static void Main()
        {
            var stats = GetStats();

            Console.WriteLine(stats);
        }

        private static AllStatistics GetStats()
        {
            try
            {
                var result = new AllStatistics()
                {
                    Map = GetMapsStats(),
                    Profile = GetProfileStats(),
                    Weapon = GetWeaponsStats()
                };
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        private static Maps GetMapsStats()
        {
            var request = (HttpWebRequest)WebRequest.Create(URL_CSGO_MAP);
            request.Method = "Get";
            request.Accept = "application/json";
            request.Headers.Add("TRN-Api-Key",API_KEY);

            var response = (HttpWebResponse)request.GetResponse();
            var responseStream = response.GetResponseStream();

            using var reader = new StreamReader(responseStream!, Encoding.Default);
            
            return JsonConvert.DeserializeObject<Maps>(reader.ReadToEnd());;
        }
        private static Weapon GetWeaponsStats()
        {
            var request = (HttpWebRequest)WebRequest.Create(URL_CSGO_WEAPON);
            request.Method = "Get";
            request.Accept = "application/json";
            request.Headers.Add("TRN-Api-Key",API_KEY);

            var response = (HttpWebResponse)request.GetResponse();
            var responseStream = response.GetResponseStream();

            using var reader = new StreamReader(responseStream!, Encoding.Default);
            
            return JsonConvert.DeserializeObject<Weapon>(reader.ReadToEnd());;
        }
        private static Profile GetProfileStats()
        {
            var request = (HttpWebRequest)WebRequest.Create(URL_CSGO);
            request.Method = "Get";
            request.Accept = "application/json";
            request.Headers.Add("TRN-Api-Key",API_KEY);

            var response = (HttpWebResponse)request.GetResponse();
            var responseStream = response.GetResponseStream();

            using var reader = new StreamReader(responseStream!, Encoding.Default);
            
            return JsonConvert.DeserializeObject<Profile>(reader.ReadToEnd());;
        }
    }
}