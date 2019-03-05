using Newtonsoft.Json;

namespace PrismSample.Core.Models
{
    public class SearchRoot
    {
        public Search[] Search { get; set; }

        [JsonProperty(PropertyName = "totalResults")]
        public string TotalResults { get; set; }

        public string Response { get; set; }
    }
}