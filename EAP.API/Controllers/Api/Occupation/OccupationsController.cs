using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using EAP.Contracts.IRepositoty.OccupationRepo;
using EAP.Shared.Dtos.OccupationsDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EAP.API.Controllers.Api.Occupation
{
    [ApiController]
    [Route("api/[controller]")]
    public class OccupationsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IOccupationsRepo _repo;
        private readonly ILogger<OccupationsController> _logger;

        public OccupationsController(IMapper mapper,
            IOccupationsRepo repo,
            ILogger<OccupationsController> logger)
        {
            this._mapper = mapper;
            this._repo = repo;
            this._logger = logger;
        }
        [HttpGet]
        [Route("OccupationsList")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllOccupations()
        {
            try
            {
                var occupations = await _repo.GetAllOccupations();
                if (occupations == null)
                {
                    return NotFound(new OccupationsRetriveResponse
                    {
                        ErrorMessage = "Occupations are not found on our record"
                    });
                }
                var responseOccupations = _mapper.Map<IEnumerable<OccupationsListDto>>(occupations);
                return Ok(responseOccupations);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something wrong when retrive the occupations from the database {ex.Message}");
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}