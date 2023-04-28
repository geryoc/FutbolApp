using AutoMapper;
using FutbolApp.Core.Domain.Entities;
using FutbolApp.Core.Models;

namespace FutbolApp.Core.Shared.Automapper;

public class AutomapperProfiles : Profile
{
    public AutomapperProfiles()
    {
        // Entities To Models
        CreateMap<Tournament, TournamentModel>();
        CreateMap<Country, CountryModel>();

        // Requests To Entities
    }
}
