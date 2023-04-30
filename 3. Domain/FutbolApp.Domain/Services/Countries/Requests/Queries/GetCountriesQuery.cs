using FutbolApp.Core.Models;
using FutbolApp.Core.Shared.Requests;
using FutbolApp.Core.Shared.Responses;
using MediatR;
using System.Text.Json.Serialization;

namespace FutbolApp.Core.Services.Countries.Requests.Queries;

public class GetCountriesQuery : PageQuery, IRequest<PageResponse<CountryModel>>
{
    public string Name { get; set; }
    public ICollection<CountryIncludes> Include { get; set; }
}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum CountryIncludes
{
    Tournaments,
}
