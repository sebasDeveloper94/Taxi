using System.Threading.Tasks;
using Taxi.Common.Models;

namespace Taxi.Common.Services
{
    public interface IApiService
    {
        Task<Response> GetTaxiAsync(string plaque, string urlBase, string servicePrefix, string controller);
    }
}
