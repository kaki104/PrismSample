using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml.Navigation;
using Prism.Windows.Mvvm;
using Prism.Windows.Navigation;
using PrismSample.Core.Helpers;
using PrismSample.Core.Models;

namespace PrismSample.ViewModels
{
    public class MovieDetailViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private string _movieId;
        private MovieDetail _currentMovieDetail;

        public MovieDetailViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override void OnNavigatedTo(NavigatedToEventArgs e, Dictionary<string, object> viewModelState)
        {
            if (e.NavigationMode == NavigationMode.New)
            {
                Debug.WriteLine(e.Parameter);
                _movieId = e.Parameter as string;

                GetMovieDetail();
            }
        }

        private async void GetMovieDetail()
        {
            if (string.IsNullOrEmpty(_movieId)) return;

            using (var client = new HttpClient())
            {
                var url = $"http://www.omdbapi.com/?i={_movieId}&apikey=32941a88";
                var result = await client.GetStringAsync(url);
                if (string.IsNullOrEmpty(result)) return;

                var movieDetail = await Json.ToObjectAsync<MovieDetail>(result);
                if (movieDetail == null) return;
                CurrentMovieDetail = movieDetail;
            }
        }
        /// <summary>
        /// 현재 영화 상세
        /// </summary>
        public MovieDetail CurrentMovieDetail
        {
            get => _currentMovieDetail;
            set => SetProperty(ref _currentMovieDetail ,value);
        }
    }
}
