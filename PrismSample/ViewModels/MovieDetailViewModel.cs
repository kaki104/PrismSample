using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml.Navigation;
using Prism.Windows.Mvvm;
using Prism.Windows.Navigation;

namespace PrismSample.ViewModels
{
    public class MovieDetailViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        public MovieDetailViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override void OnNavigatedTo(NavigatedToEventArgs e, Dictionary<string, object> viewModelState)
        {
            if (e.NavigationMode == NavigationMode.New)
            {
                Debug.WriteLine(e.Parameter);
            }
        }
    }
}
