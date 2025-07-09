using System.Text.Json.Serialization;

namespace FastFilmography.Client.Models.ActorModels
{
    public class PopularActor
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Id")]
        public int Id { get; set; }
    }
}
