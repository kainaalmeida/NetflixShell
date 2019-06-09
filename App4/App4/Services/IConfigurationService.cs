using Refit;
using System.Threading.Tasks;

namespace App4.Services
{
    public interface IConfigurationService
    {
        [Get("/configuration?api_key={ApiKey}")]
        Task<Models.MovideDbConfiguration> GetConfiguration(string apiKey);
    }
}
