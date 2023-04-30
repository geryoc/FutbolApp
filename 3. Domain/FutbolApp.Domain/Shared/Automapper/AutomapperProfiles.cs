using AutoMapper;
using FutbolApp.Core.Domain.Entities;
using FutbolApp.Core.Models;
using FutbolApp.Core.Services.Countries.Requests.Commands;

namespace FutbolApp.Core.Shared.Automapper;

public class AutomapperProfiles : Profile
{
    public AutomapperProfiles()
    {
        // Entities To Models
        CreateMap<Tournament, TournamentModel>();
        CreateMap<Country, CountryModel>();

        // Commands To Entities
        CreateMap<CreateCountryCommand, Country>();
        CreateMap<UpdateCountryCommand, Country>();
    }
}
