using Microsoft.AspNetCore.Razor.TagHelpers;
using Newtonsoft.Json;
using RestSharp;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SOA_CA1
{
    public class MovieService
    {
        public HttpClient HttpClient = new HttpClient();

        public async Task<Movies?> GetMovieAPI(string title)
        {

            string APIKey = "85c1095a";
            // showing data by movie title(user input) in api:
            string Movie_API_URL = $"https://www.omdbapi.com/?t={title}&apikey={APIKey}";

            var movieAPIResponse = await HttpClient.GetStringAsync(Movie_API_URL);

            var movie = JsonConvert.DeserializeObject<Movies>(movieAPIResponse);

            return movie;
        }
    }
}

      
 
