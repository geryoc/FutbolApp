using FutbolApp.Core.Models;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace FutbolApp.Core.Services.Countries.Requests.Queries;

public class GetCountryByIdQuery : IRequest<CountryModel>
{
    [Required]
    [Range(1, int.MaxValue)]
    public int Id { get; set; }
}
