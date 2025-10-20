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

        public async Task<MovieProvider?> GetMovieProvider(string imdbID)
        {

            string APIKey = "BXIqCHc7LDoVZ2u97BwvIlVUF8YKOGuqgAutTrqo";

            string API_URL = $"https://api.watchmode.com/v1/sources/apikey={APIKey}";

            var movieProviderResponse = await HttpClient.GetStringAsync(API_URL);

            var movieProvider = JsonConvert.DeserializeObject<MovieProvider>(movieProviderResponse);

            return movieProvider;
        }
    }
}
