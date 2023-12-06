using System;
using System.Collections.Generic;
using System.Text;
using BuscarFilmes.Common.Constants;
using BuscarFilmes.Common.Models;
using Prism.Mvvm;
using Prism.Navigation;

namespace BuscarFilmes.Common.Viewmodels
{
    class MovieDetailsPageViewModel : BindableBase, INavigationAware
    {
        private INavigationService _navigationService;
        public Movie movies;
        public Movie Movies
        {
            get => movies;
            set => SetProperty(ref movies, value);
        }

        private bool isLoadingData;

        public bool IsLoadingData
        {
            get => isLoadingData;
            set => SetProperty(ref isLoadingData, value);
        }
        public MovieDetailsPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            Movie movie = parameters[Constant.MOVIE] as Movie;
            Movies = movie;
        }
    }
}
