using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using EAP.Contracts.IRepositoty.OrganizationsRepo;
using EAP.Shared.Dtos.OrganizationsDto.OrganizationTypesDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EAP.API.Controllers.Api.Organizations
{
    [ApiController]
    [Route("Api/[controller]")]
    public class OrganizationTypesController : ControllerBase
    {
        private readonly IOrganizationTypesRepo _repo;
        private readonly IMapper _mapper;
        private readonly ILogger<OrganizationTypesController> _logger;

        public OrganizationTypesController(IOrganizationTypesRepo repo,
            IMapper mapper,
            ILogger<OrganizationTypesController> logger)
        {
            _repo = repo;
            _mapper = mapper;
            _logger = logger;
        }
        [HttpGet]
        [Route("OrganizationTypesList")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllOrganizationTypes()
        {
            try
            {
                var query = await _repo.GetAllOrganizationTypes();
                if (query == null)
                {
                    return NotFound(new OrganizationTypesListResponse
                    {
                        Message = "We haven't found more record in our system"
                    });
                }
                var queryResult = _mapper.Map<IEnumerable<OrganizationTypesForListDto>>(query);
                return Ok(query);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something wrong when retrive the Trganization Type from the database {ex.Message}");
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}