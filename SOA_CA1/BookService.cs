using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using RestSharp;

namespace SOA_CA1
{
    public class BookService
    {
        static readonly string Book_URL = "https://openlibrary.org/search.json";

        public string BookText(string searchTitle)
        {
            var client = new RestClient(Book_URL);
            var request = new RestRequest();
            request.AddParameter("q", searchTitle);
            var response = client.Execute(request);

            if (!string.IsNullOrWhiteSpace(response.Content))
            {
            //var serializer = new JsonSerializer(typeof(BooksAPI));
            //

            // https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/deserialization
                var serializer = JsonConvert.DeserializeObject<BooksAPI>(response.Content);
                return serializer.result;


                //using (StringReader sr = new(response.Content))
                //{
                //    BooksAPI? filtered = (BooksAPI?)serializer.Deserialize(sr);
                //    return filtered.result;
                //}

                //var serializer = new JsonSerializer();

                //using (StringReader sr = new(response.Content))
            }
            return string.Empty;
        }

    }

}
