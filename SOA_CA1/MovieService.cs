using RestSharp;
using System.Net.Http.Json;

namespace SOA_CA1
{
    public class MovieService(HttpClient httpClient)
    {
        public async Task<Movies> GetMovieAPI(string title)
        {
            string APIKey = "85c1095a";

            // showing data by movie title(user input) in api:
            string Movie_API_URL = $"https://www.omdbapi.com/?t={title}&apikey={APIKey}";

            return await httpClient.GetFromJsonAsync<Movies>(Movie_API_URL);
        }
    }
}

      
 
