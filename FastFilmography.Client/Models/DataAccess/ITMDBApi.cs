using FastFilmography.Client.Models.ActorModels;
using FastFilmography.Client.Models.MovieModels;
using RestSharp;

namespace FastFilmography.Client.Models.DataAccess
{
    public interface ITMDBApi
    {
        string Token { get; set; }

        Task<Actor> GetActorByIdAsync(int id);
        Task<Movie> GetMovieById(int id, bool getCredits);
        Task<RestResponse> SendRequestAsync(string url);
    }
}