using AutoMapper;
using FutbolApp.Core.Models;
using FutbolApp.Core.Services.Countries.Requests.Queries;
using FutbolApp.Core.Shared.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FutbolApp.Core.Services.Countries.Handlers;

public class GetCountryByIdHandler : IRequestHandler<GetCountryByIdQuery, CountryModel>
{
    private readonly FutbolAppContext _context;
    private readonly IMapper _mapper;

    public GetCountryByIdHandler(FutbolAppContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<CountryModel> Handle(GetCountryByIdQuery request, CancellationToken cancellationToken)
    {
        var country = await _context.Countries
            .Include(x => x.Tournaments)
            .FirstOrDefaultAsync(c => c.Id == request.Id, cancellationToken: cancellationToken);

        var countryModel = _mapper.Map<CountryModel>(country);

        return countryModel;
    }
}