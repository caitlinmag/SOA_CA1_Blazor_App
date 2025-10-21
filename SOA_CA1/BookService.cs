using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using RestSharp;

namespace SOA_CA1
{
    public class BookService
    {
        public HttpClient HttpClient = new HttpClient();

        // return a list of doc (lists of book fields)
        public async Task<Rootobject> GetBooksAPI(string bookTitle)
        {
            string Book_URL = $"https://openlibrary.org/search.json?q={bookTitle}";
            var bookAPIResponse = await HttpClient.GetStringAsync(Book_URL);
            var bookResult = JsonConvert.DeserializeObject<Rootobject>(bookAPIResponse);
            return bookResult;
        }
    }
}
