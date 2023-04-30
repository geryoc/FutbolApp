using FutbolApp.Core.Shared.Requests;
using FutbolApp.Core.Shared.Responses;

namespace FutbolApp.Core.Shared.Helpers;

public static class QueryExtensionMethods
{
    public static PageResponse<T> ToPageResource<T>(this PageQuery request, ICollection<T> items, int totalItems)
    {
        return new PageResponse<T>
        {
            PageItems = items,
            TotalItems = totalItems,
            CurrentPage = request.PageNumber,
            PageSize = request.PageSize,
        };
    }
}
