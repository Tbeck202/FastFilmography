using Newtonsoft.Json;

namespace FastFilmography.Client.Models.MovieModels
{
    public class TopRatedMovieDataSet
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("results")]
        public List<Movie> Movies { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }
    }
}
