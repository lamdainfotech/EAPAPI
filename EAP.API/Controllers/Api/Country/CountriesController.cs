using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using EAP.Contracts.IRepositoty.Wrapper;
using EAP.Entity.Models.Country;
using EAP.Shared.Dtos.CountryDto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EAP.API.Controllers.Api.Country
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountriesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IWrapperRepo _repo;
        private readonly ILogger<CountriesController> _logger;

        public CountriesController(IMapper mapper,
            IWrapperRepo repo,
            ILogger<CountriesController> logger)
        {
            this._mapper = mapper;
            this._repo = repo;
            this._logger = logger;
        }
        [HttpGet("AllCountriesList")]
        public async Task<IActionResult> GetAllCountries()
        {
            var countries = await _repo.country.GetAllCountries();
            if (countries == null)
            {
                return NotFound();
            }
            var countriesResult = _mapper.Map<IEnumerable<CountriesDto>>(countries);
            return StatusCode(200, countriesResult);
        }
        [HttpGet("LimitedCountries")]
        public async Task<IActionResult> LimitedCountries()
        {
            var countries = await _repo.country.GetLimitedCountries();
            if (countries == null)
            {
                return NotFound();
            }
            var countriesResult = _mapper.Map<IEnumerable<CountryDtoForLimitiedList>>(countries);
            return StatusCode(200, countriesResult);
        }
    }
}