using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Prism.Windows.Mvvm;
using Prism.Windows.Navigation;
using PrismSample.Core.Helpers;
using PrismSample.Core.Models;
using PrismSample.Core.Services;

namespace PrismSample.ViewModels
{
    public class MovieViewModel : ViewModelBase
    {
        private SearchRoot _searchResult;
        private IList<Search> _searchs;

        public MovieViewModel()
        {

        }

        public override async void OnNavigatedTo(NavigatedToEventArgs e, Dictionary<string, object> viewModelState)
        {
            await GetMoviesAsync();
        }

        private async Task GetMoviesAsync()
        {
            using (var client = new HttpClient())
            {
                var result = await client.GetStringAsync("http://www.omdbapi.com/?s=batman&apikey=32941a88");
                if (string.IsNullOrEmpty(result)) return;

                var searchRoot = await Json.ToObjectAsync<SearchRoot>(result);
                if (searchRoot == null) return;
                _searchResult = searchRoot;
                Searchs = _searchResult.Search.ToList();
            }
        }
        /// <summary>
        /// 검색 결과
        /// </summary>
        public IList<Search> Searchs
        {
            get => _searchs;
            set => SetProperty(ref _searchs ,value);
        }
    }
}
