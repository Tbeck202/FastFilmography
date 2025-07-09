using FastFilmography.Client.Models.ActorModels;
using FastFilmography.Client.Models.MovieModels;
using RestSharp;

namespace FastFilmography.Client.Models.DataAccess
{
    public interface ITMDBApi
    {
        string Token { get; set; }
        string PopularActorsPath { get; set; }
        Task<Actor> GetActorByIdAsync(int id);
        Task<CastAndCrewCredits> GetCastAndCrewCreditsAsync(int id);
        Task<Credits> GetCastAndCrewForMovieAsync(int id);
        Task<TopRatedMovieDataSet> GetMoviesForKeyAsync(int pageNum);
        Task<Movie> GetMovieById(int id, bool getCredits);
        Task<TMDBConfiguration> GetConfigurationAsync();
        Task<RestResponse> SendRequestAsync(string url);

    }
}