using AutoMapper;
using FutbolApp.Core.Domain.Entities;
using FutbolApp.Core.Models;
using FutbolApp.Core.Services.Countries.Requests.Commands;
using FutbolApp.Core.Shared.Database;
using MediatR;

namespace FutbolApp.Core.Services.Countries.Handlers
{
    public class CreateCountryHandler : IRequestHandler<CreateCountryCommand, CountryModel>
    {
        private readonly FutbolAppContext _db;
        private readonly IMapper _mapper;

        public CreateCountryHandler(FutbolAppContext dbContext, IMapper mapper)
        {
            _db = dbContext;
            _mapper = mapper;
        }
        
        public async Task<CountryModel> Handle(CreateCountryCommand request, CancellationToken cancellationToken)
        {
            var country = _mapper.Map<Country>(request);

            _db.Countries.Add(country);
            await _db.SaveChangesAsync(cancellationToken);

            var countryModel = _mapper.Map<CountryModel>(country);

            return countryModel;
        }
    }
}
