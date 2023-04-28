using FutbolApp.Core.Models;
using FutbolApp.Core.Services.Countries.Requests;
using FutbolApp.Core.Shared.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FutbolApp.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CountriesController : ControllerBase
{
    private IMediator _mediator;
    
    public CountriesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<PageResponse<CountryModel>> GetCountries([FromQuery] GetCountriesRequest request)
    {
        return await _mediator.Send(request);
    }
}
