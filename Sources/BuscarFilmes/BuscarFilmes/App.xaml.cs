using BuscarFilmes.Common.Repository;
using BuscarFilmes.Common.Viewmodels;
using BuscarFilmes.Common.Views;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using System;
using Xamarin.Forms;

namespace BuscarFilmes
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected async override void OnInitialized()
        {
            InitializeComponent();
            DependencyService.Register<IMovieRepository, MovieRepository>();
            try
            {
                await NavigationService.NavigateAsync("NavigationPage/MoviesPage");
            }
            catch (Exception) { }
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MoviesPage, MoviesPageViewModel>();
            containerRegistry.RegisterForNavigation<MovieDetailsPage, MovieDetailsPageViewModel>();
        }
    }
}
