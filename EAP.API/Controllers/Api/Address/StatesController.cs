using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;
using AutoMapper;
using EAP.Contracts.IRepositoty.Wrapper;
using EAP.Shared.Dtos.StatesDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EAP.API.Controllers.Api.Address
{
    [ApiController]
    [Route("api/[controller]")]
    public class StatesController : ControllerBase
    {
        private readonly IWrapperRepo _repo;
        private readonly IMapper _mapper;
        private readonly ILogger<StatesController> _logger;

        public StatesController(IWrapperRepo repo,
            IMapper mapper,
            ILogger<StatesController> logger)
        {
            this._repo = repo;
            this._mapper = mapper;
            this._logger = logger;
        }
        [HttpGet]
        [Route("StatesList")]
        public async Task<IActionResult> GetAllStates()
        {
            var states = await _repo.states.GetAllStates();

            if (states == null)
            {
                return NotFound("We dont't have any more information");
            }

            var statesResult = _mapper.Map<IEnumerable<StateDtoForAllStates>>(states);
            return StatusCode(200, statesResult);
        }
        [HttpGet]
        [Route("OnlyStates")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ResponseCache(Duration = 10, Location = ResponseCacheLocation.Any, NoStore = true)]
        public async Task<IActionResult> GetOnlyStates()
        {
            var states = await _repo.states.GetOnlyStates();

            if (states == null)
            {
                return NotFound("We dont't have any more information");
            }

            var statesResult = _mapper.Map<IEnumerable<StatesDtoForOnlyState>>(states);
            return StatusCode(200, statesResult);
        }
    }
}