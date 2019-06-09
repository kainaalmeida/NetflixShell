using Refit;
using System.Threading.Tasks;

namespace App4.Services
{
    public interface ITopRatedService
    {
        [Get("/movie/top_rated?api_key={ApiKey}&language={Language}&page={Page}")]
        Task<Models.TopRated> GetMoviesTopRated(string apiKey, string language, int page);
    }
}
