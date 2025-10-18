using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Newtonsoft.Json;
using RestSharp;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SOA_CA1
{
    public class MovieService(HttpClient httpClient)
    {
        static readonly string Movie_API_URL = "http://www.omdbapi.com/?";

        public string MovieText(string searchTitle)
        {
            var client = new RestClient(Movie_API_URL);
            var request = new RestRequest();
            request.AddParameter("s", searchTitle);
            var response = client.Execute(request);

            if (!string.IsNullOrWhiteSpace(response.Content))
            {
                var serializer = JsonConvert.DeserializeObject<MoviesAPI>(response.Content);
                return serializer.Response;
            }
        }
    }
}
