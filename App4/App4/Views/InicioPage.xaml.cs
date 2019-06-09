using App4.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InicioPage : ContentPage
    {
        private InicioPageViewModel ViewModel => BindingContext as InicioPageViewModel;

        public InicioPage()
        {
            InitializeComponent();
            BindingContext = new InicioPageViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await ViewModel.GetConfigurationMovieDb();
        }
    }
}