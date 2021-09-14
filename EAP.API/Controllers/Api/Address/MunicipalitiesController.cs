using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using EAP.Contracts.IRepositoty.AddressRepo;
using EAP.Shared.Dtos.MunicipalityDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EAP.API.Controllers.Api.Address
{
    [Route("api/[controller]")]
    [ApiController]
    public class MunicipalitiesController : ControllerBase
    {
        private readonly IMunicipalitiesRepo _repo;
        private readonly IMapper _mapper;
        private readonly ILogger<MunicipalitiesController> _logger;

        public MunicipalitiesController(IMunicipalitiesRepo repo,
            IMapper map,
            ILogger<MunicipalitiesController> logger)
        {
            this._repo = repo;
            this._mapper = map;
            this._logger = logger;
        }
        [HttpGet]
        [Route("GPNPList")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ResponseCache(Duration = 10, Location = ResponseCacheLocation.Any, NoStore = true)]
        public async Task<IActionResult> GetAllMunicipalities()
        {
            var query = await _repo.GetAllMunicipalities();
            var queryResult = _mapper.Map<IEnumerable<MunicipalityListDto>>(query);
            return Ok(queryResult);
        }
        [HttpGet]
        [Route("GetGPNPByDistrict/{Id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ResponseCache(Duration = 10, Location = ResponseCacheLocation.Any, NoStore = true)]
        public async Task<IActionResult> GetMunicipalityByDistrict(int Id)
        {
            try
            {
                var query = await _repo.GetMunicipalityByDistrict(Id);

                if (query != null)
                {
                    _logger.LogError($"Owner with id: {Id} hasn't been found in our record!");
                    return NotFound();
                }

                var queryResult = _mapper.Map<IEnumerable<MunicipalityByDistrictDto>>(query);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something wrong when getting getting the selected id: {Id}, {ex.Message}");
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}