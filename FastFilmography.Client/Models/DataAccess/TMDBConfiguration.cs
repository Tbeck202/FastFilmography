using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;

namespace FastFilmography.Client.Models.DataAccess
{
    public class TMDBConfiguration
    {
        [JsonProperty("change_keys")]
        public List<string> ChangeKeys { get; set; }

        [JsonProperty("images")]
        public TMDBImages Images { get; set; }
    }
}
