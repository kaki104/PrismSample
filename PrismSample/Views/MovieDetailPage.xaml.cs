using System;

using PrismSample.ViewModels;

using Windows.UI.Xaml.Controls;

namespace PrismSample.Views
{
    public sealed partial class MovieDetailPage : Page
    {
        private MovieDetailViewModel ViewModel => DataContext as MovieDetailViewModel;

        public MovieDetailPage()
        {
            InitializeComponent();
        }
    }
}
