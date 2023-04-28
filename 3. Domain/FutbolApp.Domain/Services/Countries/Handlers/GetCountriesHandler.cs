using AutoMapper;
using FutbolApp.Core.Models;
using FutbolApp.Core.Services.Countries.Helpers;
using FutbolApp.Core.Services.Countries.Requests;
using FutbolApp.Core.Shared.Database;
using FutbolApp.Core.Shared.Helpers;
using FutbolApp.Core.Shared.Responses;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FutbolApp.Core.Services.Countries.Handlers;

public class GetCountriesHandler : IRequestHandler<GetCountriesRequest, PageResponse<CountryModel>>
{
    private readonly FutbolAppContext _context;
    private readonly IMapper _mapper;

    public GetCountriesHandler(FutbolAppContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<PageResponse<CountryModel>> Handle(GetCountriesRequest request, CancellationToken cancellationToken)
    {
        var query = _context.Countries.AsQueryable();

        query = query.AddIncludes(request.Include);
        query = query.Where(c => string.IsNullOrEmpty(request.Name) || c.Name.Contains(request.Name));
        
        var items = await query.ToListAsync(cancellationToken: cancellationToken);
        var totalItems = await query.CountAsync(cancellationToken: cancellationToken);

        var pageItems = _mapper.Map<List<CountryModel>>(items);
        var pageResult = request.ToPageResource(pageItems, totalItems);

        return pageResult;
    }
}
