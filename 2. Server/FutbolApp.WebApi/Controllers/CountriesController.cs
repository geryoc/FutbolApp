using FutbolApp.Core.Models;
using FutbolApp.Core.Services.Countries.Requests.Commands;
using FutbolApp.Core.Services.Countries.Requests.Queries;
using FutbolApp.Core.Shared.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FutbolApp.WebApi.ApiControllers;

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
    public async Task<PageResponse<CountryModel>> Get([FromQuery] GetCountriesQuery request)
    {
        return await _mediator.Send(request);
    }

    [HttpGet("{Id}")]
    public async Task<CountryModel> GetById([FromRoute] GetCountryByIdQuery request)
    {
        return await _mediator.Send(request);
    }

    [HttpPost]
    public async Task<CountryModel> Create([FromBody] CreateCountryCommand request)
    {
        return await _mediator.Send(request);
    }

    [HttpPut]
    public async Task<CountryModel> Update([FromBody] UpdateCountryCommand request)
    {
        return await _mediator.Send(request);
    }

    [HttpDelete("{id}")]
    public async Task Delete([FromRoute] DeleteCountryCommand request)
    {
        await _mediator.Send(request);
    }
}
