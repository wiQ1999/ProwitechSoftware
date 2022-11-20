
using Application.BuildingAddresses.Commands.Requests;
using Application.BuildingAddresses.DTOs;
using Application.BuildingAddresses.Queries.Requests;
using Application.Buildings.Commands.Requests;
using Application.Buildings.Queries.Requests;
using Application.PropertyManagers.Commands.Requests;
using Application.PropertyManagers.Queries.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("[controller]")]
    public class BuildingController:ApiControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get() =>
            Ok(await Mediator.Send(new GetAllBuildingsQuery()));

        [HttpPost]
        public async Task<IActionResult> Create(CreateBuildingCommand comamnd)=>
            Ok(await Mediator.Send(comamnd));

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> Get(Guid id) =>
            Ok(await Mediator.Send(new GetBuildingByIdQuery() {Id=id }));

        
        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> Update(Guid id, UpdateBuildingCommand command)
        {
            if (id != command.Id)
                return BadRequest();
            return Ok(await Mediator.Send(command));
        }
        
        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> Detele(Guid id) =>
            Ok(await Mediator.Send(new DeleteBuildingCommand
            {
                Id = id
            }));

    }
    }
