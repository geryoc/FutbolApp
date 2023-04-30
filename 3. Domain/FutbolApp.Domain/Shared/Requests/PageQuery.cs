using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FutbolApp.Core.Shared.Requests
{
    public class PageQuery
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;

        [BindNever]
        public int Skip => (PageNumber - 1) * PageSize;

        [BindNever]
        public int Take => PageSize;
    }
}
