using System.Text.Json.Serialization;

namespace FutbolApp.Core.Shared.Requests
{
    public class PageRequest
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;

        [JsonIgnore]
        public int Skip => (PageNumber - 1) * PageSize;

        [JsonIgnore]
        public int Take => PageSize;
    }
}
