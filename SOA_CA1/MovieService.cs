using RestSharp;
using System.Net.Http.Json;

namespace SOA_CA1
{
    public class MovieService(HttpClient httpClient)
    {
        public async Task<Movies> GetMovieAPI()
        {
            string Movie_API_URL = "https://www.omdbapi.com/?i=tt3896198&apikey=85c1095a";
            return await httpClient.GetFromJsonAsync<Movies>(Movie_API_URL);
        }
    }
}

      
 
