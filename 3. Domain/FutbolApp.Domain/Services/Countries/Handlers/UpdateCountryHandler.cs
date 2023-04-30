using AutoMapper;
using FutbolApp.Core.Domain.Entities;
using FutbolApp.Core.Models;
using FutbolApp.Core.Services.Countries.Requests.Commands;
using FutbolApp.Core.Shared.Database;
using FutbolApp.Core.Shared.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FutbolApp.Core.Services.Countries.Handlers;

public class UpdateCountryHandler : IRequestHandler<UpdateCountryCommand, CountryModel>
{
    private readonly FutbolAppContext _db;
    private readonly IMapper _mapper;

    public UpdateCountryHandler(FutbolAppContext context, IMapper mapper)
    {
        _db = context;
        _mapper = mapper;
    }

    public async Task<CountryModel> Handle(UpdateCountryCommand request, CancellationToken cancellationToken)
    {
        bool exists = await _db.Countries.AnyAsync(c => c.Id == request.Id, cancellationToken: cancellationToken);

        if (!exists)
        {
            throw ValidationException.From(
                code: "COUNTRY_NOT_FOUND", 
                message: $"COUNTRY Not Found. ID = '{request.Id}'");
        }

        var country = _mapper.Map<Country>(request);

        _db.Countries.Update(country);
        await _db.SaveChangesAsync(cancellationToken);

        return _mapper.Map<CountryModel>(country);
    }
}
