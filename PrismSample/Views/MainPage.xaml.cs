using System;

using PrismSample.ViewModels;

using Windows.UI.Xaml.Controls;

namespace PrismSample.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel => DataContext as MainViewModel;

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
