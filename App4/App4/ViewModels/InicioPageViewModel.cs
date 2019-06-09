using App4.Models;
using App4.Services;
using Refit;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace App4.ViewModels
{
    public class InicioPageViewModel : BaseViewModel
    {
        public ObservableCollection<Movies> Kaina { get; set; } = new ObservableCollection<Movies>();
        public ObservableCollection<Movies> Recentes { get; set; } = new ObservableCollection<Movies>();
        public ObservableCollection<Movies> EmAlta { get; set; } = new ObservableCollection<Movies>();
        public ObservableCollection<Movies> Original { get; set; } = new ObservableCollection<Movies>();
        public ObservableCollection<Movies> Disponivel { get; set; } = new ObservableCollection<Movies>();

        private Movies movies;
        public Movies Movies
        {
            get { return movies; }
            set { SetProperty(ref movies, value); }
        }


        public async Task GetConfigurationMovieDb()
        {
            var configurationService = RestService.For<IConfigurationService>(EndPoints.BaseUrl);
            var topRatedService = RestService.For<ITopRatedService>(EndPoints.BaseUrl);
            var result = await configurationService.GetConfiguration(EndPoints.ApiKey);

            if (result != null)
            {
                var movies = await topRatedService.GetMoviesTopRated(EndPoints.ApiKey, "pt-BR", 1);

                if (movies != null)
                {
                    foreach (var item in movies.results)
                    {
                        item.url_image = $"{result.images.base_url}{result.images.poster_sizes[2]}{item.poster_path}";
                        Kaina.Add(item);
                    }
                }

                var recente = await topRatedService.GetMoviesTopRated(EndPoints.ApiKey, "pt-BR", 2);

                if (recente != null)
                {
                    foreach (var item in recente.results)
                    {
                        item.url_image = $"{result.images.base_url}{result.images.poster_sizes[2]}{item.poster_path}";
                        Recentes.Add(item);
                    }
                }

                var emAlta = await topRatedService.GetMoviesTopRated(EndPoints.ApiKey, "pt-BR", 3);

                if (emAlta != null)
                {
                    foreach (var item in emAlta.results)
                    {
                        item.url_image = $"{result.images.base_url}{result.images.poster_sizes[2]}{item.poster_path}";
                        EmAlta.Add(item);
                    }
                }

                var original = await topRatedService.GetMoviesTopRated(EndPoints.ApiKey, "pt-BR", 4);

                if (original != null)
                {
                    foreach (var item in original.results)
                    {
                        item.url_image = $"{result.images.base_url}{result.images.poster_sizes[2]}{item.poster_path}";
                        Original.Add(item);
                    }
                }

                var disponivel = await topRatedService.GetMoviesTopRated(EndPoints.ApiKey, "pt-BR", 5);

                if (disponivel != null)
                {
                    foreach (var item in disponivel.results)
                    {
                        item.url_image = $"{result.images.base_url}{result.images.backdrop_sizes[1]}{item.backdrop_path}";
                        Disponivel.Add(item);
                    }
                    Movies = Disponivel[2];
                }
            }

        }

    }

}
