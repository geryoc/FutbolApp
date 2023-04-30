using AutoMapper;
using FutbolApp.Core.Services.Countries.Requests.Commands;
using FutbolApp.Core.Shared.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FutbolApp.Core.Services.Countries.Handlers;

public class DeleteCountryHandler : IRequestHandler<DeleteCountryCommand>
{
    private readonly FutbolAppContext _db;
    private readonly IMapper _mapper;
    
    public DeleteCountryHandler(FutbolAppContext context, IMapper mapper)
    {
        _db = context;
        _mapper = mapper;
    }

    public async Task Handle(DeleteCountryCommand request, CancellationToken cancellationToken)
    {
        var country = await _db.Countries.FirstOrDefaultAsync(c => c.Id == request.Id, cancellationToken: cancellationToken);
        _db.Countries.Remove(country);
        await _db.SaveChangesAsync(cancellationToken);
    }
}
