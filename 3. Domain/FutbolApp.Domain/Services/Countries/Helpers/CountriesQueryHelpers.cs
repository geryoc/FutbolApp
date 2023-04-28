using FutbolApp.Core.Domain.Entities;
using FutbolApp.Core.Services.Countries.Requests;
using Microsoft.EntityFrameworkCore;

namespace FutbolApp.Core.Services.Countries.Helpers;

public static class CountriesQueryHelpers
{
    public static IQueryable<Country> AddIncludes(this IQueryable<Country> query, ICollection<CountryIncludes> includes)
    {
        if (includes == null || !includes.Any())
        {
            return query;
        }

        foreach (var include in includes)
        {
            switch (include)
            {
                case CountryIncludes.Tournaments:
                    query = query.Include(c => c.Tournaments);
                    break;
                default:
                    break;
            }
        }

        return query;
    }
}
