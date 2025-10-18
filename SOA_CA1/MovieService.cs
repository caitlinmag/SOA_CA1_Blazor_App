using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Newtonsoft.Json;
using RestSharp;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Net.Http.Json;

namespace SOA_CA1
{
    public class MovieService(HttpClient httpClient)
    {

        string Movie_API_URL = "https://www.omdbapi.com/?i=tt3896198&apikey=85c1095a";

        // movies = await HttpClient.GetFromJsonAsync<List<Movies>>(Movie_API_URL);
        //movie = await HttpClient.GetFromJsonAsync<Movies>(Movie_API_URL);


        //static readonly string Movie_API_URL = "http://www.omdbapi.com/?";

        //public string MovieText(string searchTitle)
        //{
        //    var client = new RestClient(Movie_API_URL);
        //    var request = new RestRequest();
        //    request.AddParameter("s", searchTitle);
        //    var response = client.Execute(request);

        //    if (!string.IsNullOrWhiteSpace(response.Content))
        //    {
        //        var serializer = JsonConvert.DeserializeObject<MoviesAPI>(response.Content);
        //        return serializer.Response;
        //    }
        //}

    }
}