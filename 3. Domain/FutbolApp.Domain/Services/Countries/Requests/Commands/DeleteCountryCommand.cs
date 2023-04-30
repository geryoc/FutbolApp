using MediatR;
using System.ComponentModel.DataAnnotations;

namespace FutbolApp.Core.Services.Countries.Requests.Commands;

public class DeleteCountryCommand : IRequest
{
    [Required]
    [Range(1, int.MaxValue)]
    public int Id { get; set; }
}
