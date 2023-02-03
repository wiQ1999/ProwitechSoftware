using Application.PropertyManagers.Commands.Requests;
using Application.PropertyManagers.Queries.Requests;
using Application.Roles.Commands.Requests;
using Application.Roles.Queries.Requests;
using Infrastructure.Models.Enums;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Web.Authorization;

namespace Web.Controllers
{
    [Route("[controller]")]
    public class PropertyManagerController : ApiControllerBase
    {
        [HttpPost]
        [SourcePermissions(AppSource.PropertyManagers, PermissionProperty.Create)]
        public async Task<IActionResult> Create(CreatePropertyManagerCommand command)
        {
            return Ok(await Mediator.Send(command));
        }
        [HttpPut("{id:Guid}")]
        [SourcePermissions(AppSource.PropertyManagers, PermissionProperty.Update)]
        public async Task<IActionResult> Update (Guid id, UpdatePropertyManagerCommand command)
        {
            if (id != command.Id)
                return BadRequest();
            return Ok(await Mediator.Send(command));
        }
        [HttpGet]
        [SourcePermissions(AppSource.PropertyManagers, PermissionProperty.Read)]
        public async Task<IActionResult> Get() =>
            Ok(await Mediator.Send(new GetAllPropertyManagersQuery()));

        [HttpGet("{id:Guid}")]
        [SourcePermissions(AppSource.PropertyManagers, PermissionProperty.Read)]
        public async Task<IActionResult> Get(Guid id) =>
            Ok(await Mediator.Send(new GetPropertyManagerByIdQuery
            {
                Id = id
            }));

        [HttpDelete("{id:Guid}")]
        [SourcePermissions(AppSource.PropertyManagers, PermissionProperty.Delete)]
        public async Task<IActionResult> Delete(Guid id) =>
            Ok(await Mediator.Send(new DeletePropertyManagerCommand() { Id=id}));
    }

}
