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
    public class MovieService: Service<Movies>, IService<Movies>
    {
        public override async Task<Movies?> GetAPIData(string title)
        {
            string APIKey = "85c1095a";
            string Movie_API_URL = $"https://www.omdbapi.com/?t={title}&apikey={APIKey}";
            // showing data by movie title(user input) in api:
            // Reference used for using httpclient and async https://www.youtube.com/watch?v=WxgYDAU4Ppw
            var movieAPIResponse = await HttpClient.GetStringAsync(Movie_API_URL);

            var movie = JsonConvert.DeserializeObject<Movies>(movieAPIResponse);

            return movie;
        }
    }
}

      
 
