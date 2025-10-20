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
    public class ProviderService
    {
        public HttpClient HttpClient = new HttpClient();

        public async Task<MovieProvider?> GetMovieProvider(string tmdbId)
        {

            string APIKey = "eyJhbGciOiJIUzI1NiJ9.eyJhdWQiOiI0MTlmYjc4N2Y0OTcxMGY2MzI5OGRkNDgxMmU3MmQ5YyIsIm5iZiI6MTc2MDk4NjAwMS4yMzUwMDAxLCJzdWIiOiI2OGY2ODM5MWIzNDZiZTE4Yjg4ZjhiNjMiLCJzY29wZXMiOlsiYXBpX3JlYWQiXSwidmVyc2lvbiI6MX0.Bz_LUmCr2DDtRnyUFqhOy-oQ6w4kTkNOq9-W2yLDf50";

            string API_URL = $"https://api.themoviedb.org/3/movie/{tmdbId}/watch/providers?apikey={APIKey}";

            var movieProviderResponse = await HttpClient.GetStringAsync(API_URL);

            var movieProvider = JsonConvert.DeserializeObject<MovieProvider>(movieProviderResponse);

            return movieProvider;
        }
    }
}
