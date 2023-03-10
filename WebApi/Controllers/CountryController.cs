using Domain.Dtos;
using Domain.Filters;
using Domain.Wrapper;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class CountryController : ApiBaseController
{
    private readonly ICountryService _countryService;

    public CountryController(ICountryService countryService)
    {
        _countryService = countryService;
    }

    public IActionResult Test()
    {
        return Ok("hi");
    }

      public IActionResult SendEmail()
    {
        return Ok("hi");
    }
    [HttpGet]
    public async Task<PagedResponse<List<CountryDto>>> GetCountries([FromQuery] CountryFilter filter) => await _countryService.GetCountries(filter);
}