using FastFilmography.Client.Models.MovieModels;
using Newtonsoft.Json;

namespace FastFilmography.Client.Models.ActorModels
{
    public class Filmography
    {
        [JsonProperty("cast")]
        public List<CastMember> Cast { get; set; }

        [JsonProperty("crew")]
        public List<CrewMember> Crew { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
