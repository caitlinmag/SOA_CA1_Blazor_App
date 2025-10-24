using System.Threading.Tasks;

namespace SOA_CA1
{
    internal interface IService<T>
    {
        Task<T> GetAPIData(string data);
    }
}
