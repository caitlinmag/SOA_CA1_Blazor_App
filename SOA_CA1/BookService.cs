using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using RestSharp;

namespace SOA_CA1
{
    public class BookService: Service<Rootobject>, IService<Rootobject>
    {
        // return a list of doc (lists of book fields)
        public override async Task<Rootobject> GetAPIData(string bookTitle)
        {
            string Book_URL = $"https://openlibrary.org/search.json?q={bookTitle}";
            var bookAPIResponse = await HttpClient.GetStringAsync(Book_URL);
            return JsonConvert.DeserializeObject<Rootobject>(bookAPIResponse);
        }
    }
}
