using Newtonsoft.Json;

namespace FastFilmography.Client.Models.ActorModels
{
    public class CastAndCrewCredits
    {
        [JsonProperty("cast")]
        public List<CastCredit> CastCredits { get; set; }

        [JsonProperty("crew")]
        public List<CrewCredit> CrewCredits { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
}