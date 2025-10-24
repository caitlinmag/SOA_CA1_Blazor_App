using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using RestSharp;

namespace SOA_CA1
{
    public abstract class Service<T>
    {
        public HttpClient HttpClient = new HttpClient();
        public abstract Task<T> GetAPIData(string data);
    }
}
