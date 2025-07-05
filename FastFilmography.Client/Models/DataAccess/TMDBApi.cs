using FastFilmography.Client.Models.ActorModels;
using FastFilmography.Client.Models.MovieModels;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FastFilmography.Client.Models.DataAccess
{
    public class TMDBApi : ITMDBApi
    {
        private readonly IConfiguration _configuration;
        public string Token { get; set; }
        public string PopularActorsPath { get; set; }
        public TMDBApi(IConfiguration configuration)
        {
            _configuration = configuration;
            Token = _configuration["Token"]!;
            PopularActorsPath = _configuration["PopularActorsPath"]!;
        }
        public async Task<RestResponse> SendRequestAsync(string url)
        {
            var options = new RestClientOptions(url);
            var client = new RestClient(options);
            var request = new RestRequest("");
            request.AddHeader("accept", "application/json");
            request.AddHeader("Authorization", $"Bearer {Token}");

            try
            {
                RestResponse response = await client.GetAsync(request);
                return response;
            }
            catch (Exception ex)
            {
                return new RestResponse();
            }
        }

        public async Task<TMDBConfiguration> GetConfigurationAsync()
        {
            TMDBConfiguration configuration = new();
            try
            {
                string url = "https://api.themoviedb.org/3/configuration?language=en-US";
                var response = await SendRequestAsync(url);
                configuration = JsonConvert.DeserializeObject<TMDBConfiguration>(response.Content);
            }
            catch (Exception ex) { }
            return configuration;
        }

        public async Task<Actor> GetActorByIdAsync(int id)
        {
            Actor actor = new();
            Filmography filmography = new();

            try
            {
                string url = $"https://api.themoviedb.org/3/person/{id.ToString()}?append_to_response=movie_credits&language=en-US";
                var response = await SendRequestAsync(url);
                actor = JsonConvert.DeserializeObject<Actor>(response.Content);
            }
            catch (Exception ex) { }

            return actor;
        }

        public async Task<CastAndCrewCredits> GetCastAndCrewCreditsAsync(int id)
        {
            CastAndCrewCredits castAndCrewCredits = new();
            try
            {
                string url = $"https://api.themoviedb.org/3/person/{id.ToString()}/movie_credits?language=en-US";
                var response = await SendRequestAsync(url);
                castAndCrewCredits = JsonConvert.DeserializeObject<CastAndCrewCredits>(response.Content);
            }
            catch (Exception ex) { }
            return castAndCrewCredits;
        }

        public async Task<Movie> GetMovieById(int id, bool getCredits)
        {
            Movie movie = new();
            try
            {
                string url = getCredits ?
                    $"https://api.themoviedb.org/3/movie/{id.ToString()}?append_to_response=%2Ccredits&language=en-US" :
                    $"https://api.themoviedb.org/3/movie/{id.ToString()}?language=en-US";
                var response = await SendRequestAsync(url);
                movie = JsonConvert.DeserializeObject<Movie>(response.Content);
            }
            catch (Exception ex) { }

            return movie;
        }
    }
}
