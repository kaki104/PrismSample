using System;

using PrismSample.ViewModels;

using Windows.UI.Xaml.Controls;

namespace PrismSample.Views
{
    public sealed partial class SamplePage : Page
    {
        private SampleViewModel ViewModel => DataContext as SampleViewModel;

        public SamplePage()
        {
            InitializeComponent();
        }
    }
}
