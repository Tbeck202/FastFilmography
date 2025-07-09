using Newtonsoft.Json;

namespace FastFilmography.Client.Models.MovieModels
{
    public class Credits
    {
        [JsonProperty("cast")]
        public List<CastMember> Cast { get; set; }

        [JsonProperty("crew")]
        public List<CrewMember> Crew { get; set; }
    }
}
