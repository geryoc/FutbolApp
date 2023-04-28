namespace FutbolApp.Core.Shared.Responses
{
    public class PageResponse<T>
    {
        public int TotalItems { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public ICollection<T> PageItems { get; set; }
    }
}
