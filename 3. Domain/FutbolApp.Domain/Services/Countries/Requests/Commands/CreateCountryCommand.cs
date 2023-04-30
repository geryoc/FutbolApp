using FutbolApp.Core.Models;
using MediatR;

namespace FutbolApp.Core.Services.Countries.Requests.Commands;

public class CreateCountryCommand : CountryCommand, IRequest<CountryModel>
{
}
