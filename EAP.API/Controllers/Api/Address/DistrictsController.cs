using System.Threading.Tasks;
using AutoMapper;
using EAP.Contracts.IRepositoty.Wrapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using EAP.Shared.Dtos.DistrictsDto;
using EAP.Contracts.IRepositoty.AddressRepo;

namespace EAP.API.Controllers.Api.Address
{
    [ApiController]
    [Route("api/[controller]")]
    public class DistrictsController : ControllerBase
    {
        private readonly IDistrictsRepo _repo;
        private readonly ILogger<DistrictsController> _logger;
        private readonly IMapper _mapper;

        public DistrictsController(IDistrictsRepo repo,
            ILogger<DistrictsController> logger,
            IMapper mapper)
        {
            _repo = repo;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("DistrictList")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ResponseCache(Duration = 10, Location = ResponseCacheLocation.Any, NoStore = true)]
        public async Task<IActionResult> GetAllDistricts()
        {
            var districts = await _repo.GetDistrictList();
            var districtsResult = _mapper.Map<IEnumerable<DistrictListDto>>(districts);
            return Ok(districts);
        }
        [HttpGet]
        [Route("GetDistrictByStateId/{Id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ResponseCache(Duration = 10, Location = ResponseCacheLocation.Any, NoStore = true)]
        public async Task<IActionResult> GetDistrictByState(int Id)
        {
            var query = await _repo.GetDistrictsByState(Id);
            var result = _mapper.Map<IEnumerable<DistrictsByStateDto>>(query);
            return Ok(result);
        }
    }
}