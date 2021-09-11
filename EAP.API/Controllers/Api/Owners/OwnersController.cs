using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using EAP.API.ActionFilter;
using EAP.Contracts.IRepositoty.Wrapper;
using EAP.Entity.Models.Accounts;
using EAP.Entity.Models.Owners;
using EAP.Shared.Dtos.Owners;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EAP.API.Controllers.Api.Owners
{
    [ApiController]
    [Route("api/[controller]")]
    public class OwnersController : ControllerBase
    {
        private readonly IWrapperRepo _repo;
        private ILogger<OwnersController> _logger;
        private IMapper _mapper;

        public OwnersController(IWrapperRepo repo,
            ILogger<OwnersController> logger,
            IMapper mapper)
        {
            this._repo = repo;
            this._logger = logger;
            this._mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllOwner()
        {
            var owners = await _repo.Owner.GetAllOwners();
            _logger.LogInformation("Return all owners from database");
            var ownerResult = _mapper.Map<IEnumerable<OwnerDto>>(owners);
            return StatusCode(200, ownerResult);
        }
        [HttpGet("{id}")]
        [ServiceFilter(typeof(ValidateEntityExistaAttribute<Owner>))]
        public async Task<IActionResult> GetOwnerById(Guid id)
        {
            var owner = await _repo.Owner.GetOwnerById(id);
            if (owner == null)
            {
                _logger.LogError($"Owner with id: {id} hasn't been found in our database");
                return NotFound();
            }

            _logger.LogInformation($"Returned owner with id: {id}");
            var owner1 = HttpContext.Items["entity"] as Owner;
            var ownerResult = _mapper.Map<OwnerDto>(owner);
            return Ok(ownerResult);
        }
        [HttpGet("{id}/account")]
        [ServiceFilter(typeof(ValidateEntityExistaAttribute<OwnerDto>))]
        public async Task<IActionResult> GetOwnerWithDetails(Guid id)
        {
            var owner = await _repo.Owner.GetOwnerWithDetails(id);
            if (owner == null)
            {
                _logger.LogError($"Owner with id: {id} hasn't been found in our record!");
                return NotFound();
            }
            _logger.LogInformation($"Returned owner with details for id {id}");
            var ownerResult = _mapper.Map<OwnerDto>(owner);
            return Ok(ownerResult);
        }
        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public IActionResult CreateOwner(OwnerCreateDto owner)
        {
            // if (owner == null)
            // {
            //     _logger.LogError("Owner object sent from the client is null");
            //     return BadRequest("Owner object is null");
            // }
            // if (!ModelState.IsValid)
            // {
            //     _logger.LogError("Invalid owner object sent from the client");
            //     return BadRequest("Invalid model object");
            // }
            var ownerEntity = _mapper.Map<Owner>(owner);
            var accountEntity = _mapper.Map<Account>(owner.Accounts);
            _repo.Owner.CreateOwner(ownerEntity);
            _repo.Account.CreateAccount(accountEntity);
            _repo.Save();

            var createdOwner = _mapper.Map<OwnerDto>(ownerEntity);
            return CreatedAtAction(nameof(GetOwnerById), new { id = createdOwner.Id },
                createdOwner);
        }
        [HttpPut("{id}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> OwnerInfoUpdate(Guid id, OwnerForUpdateDto owner)
        {
            // if (owner == null)
            // {
            //     _logger.LogError($"Owner object sent from the clinet is null");
            //     return BadRequest("Owner object is null");
            // }


            // if (!ModelState.IsValid)
            // {
            //     _logger.LogError("Invalid owner object sent from the client");
            //     return BadRequest("Invalid model object");
            // }

            var ownerEntity = _repo.Owner.GetOwnerById(id);

            if (ownerEntity == null)
            {
                _logger.LogError($"Owner with id : {id} hasn't been found on our record");
                return NotFound();
            }

            await _mapper.Map(owner, ownerEntity);

            _repo.Owner.UpdateOwner(await ownerEntity);
            _repo.Save();

            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOwner(Guid id)
        {
            var owner = await _repo.Owner.GetOwnerById(id);
            if (owner == null)
            {
                _logger.LogError($"Owner with id : {id} hasn't been found on our record");
                return NotFound();
            }

            _repo.Owner.DeleteOwner(owner);
            _repo.Save();

            return NoContent();
        }
    }
}