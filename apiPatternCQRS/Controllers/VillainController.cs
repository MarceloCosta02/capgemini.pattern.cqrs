using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiPatternCQRS.WebApi.Application.Models.RequestModels.CommandRequestModels;
using apiPatternCQRS.WebApi.Application.Models.RequestModels.QueryRequestModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace apiPatternCQRS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VillainController : ControllerBase
    {
        private readonly IMediator _mediator;

        public VillainController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public IActionResult CreateVillain([FromBody] InsertVillainRequestModel request)
        {
            try
            {
                var response = _mediator.Send(request);
                return Created(string.Empty, response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetVillainById(int id)
        {
            try
            {
                GetVillainByIdRequestModel villainId = new GetVillainByIdRequestModel(id);
                var response = await _mediator.Send(villainId);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
