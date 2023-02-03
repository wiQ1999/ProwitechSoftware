
using Application.BuildingAddresses.Commands.Requests;
using Application.BuildingAddresses.DTOs;
using Application.BuildingAddresses.Queries.Requests;
using Application.Buildings.Commands.Requests;
using Application.Buildings.Queries.Requests;
using Application.PropertyManagers.Commands.Requests;
using Application.PropertyManagers.Queries.Requests;
using Infrastructure.Models.Enums;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Web.Authorization;

namespace Web.Controllers
{
    [Route("[controller]")]
    public class BuildingController:ApiControllerBase
    {
        [HttpGet]
        [SourcePermissions(AppSource.Buildings, PermissionProperty.Read)]
        public async Task<IActionResult> Get() =>
            Ok(await Mediator.Send(new GetAllBuildingsQuery()));

        [HttpPost]
        [SourcePermissions(AppSource.Buildings, PermissionProperty.Create)]
        public async Task<IActionResult> Create(CreateBuildingCommand comamnd)=>
            Ok(await Mediator.Send(comamnd));

        [HttpGet("{id:Guid}")]
        [SourcePermissions(AppSource.Buildings, PermissionProperty.Read)]
        public async Task<IActionResult> Get(Guid id) =>
            Ok(await Mediator.Send(new GetBuildingByIdQuery() {Id=id }));

        
        [HttpPut("{id:Guid}")]
        [SourcePermissions(AppSource.Buildings, PermissionProperty.Update)]
        public async Task<IActionResult> Update(Guid id, UpdateBuildingCommand command)
        {
            if (id != command.Id)
                return BadRequest();
            return Ok(await Mediator.Send(command));
        }
        
        [HttpDelete("{id:Guid}")]
        [SourcePermissions(AppSource.Buildings, PermissionProperty.Delete)]
        public async Task<IActionResult> Delete(Guid id) =>
            Ok(await Mediator.Send(new DeleteBuildingCommand
            {
                Id = id
            }));
    }
    }
