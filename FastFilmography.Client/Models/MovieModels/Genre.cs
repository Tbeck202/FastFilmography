using Newtonsoft.Json;

namespace FastFilmography.Client.Models.MovieModels
{
    public class Genre
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}