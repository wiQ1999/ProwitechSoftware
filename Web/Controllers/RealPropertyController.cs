using Application.RealProperties.Commands.Requests;
using Application.RealProperties.Queries.Requests;
using Infrastructure.Models.Enums;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Web.Authorization;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Web.Controllers
{
    [Route("[controller]")]
    public class RealPropertyController : ApiControllerBase
    {
        [HttpGet]
        [SourcePermissions(AppSource.RealProperties, PermissionProperty.Read)]
        public async Task<IActionResult> Get() =>
                Ok(await Mediator.Send(new GetAllRealPropertiesQuery()));

        [HttpPost]
        [SourcePermissions(AppSource.RealProperties, PermissionProperty.Create)]
        public async Task<IActionResult> Create(CreateRealPropertyCommand command) =>
            Ok(await Mediator.Send(command));

        [HttpGet("{id:Guid}")]
        [SourcePermissions(AppSource.RealProperties, PermissionProperty.Read)]
        public async Task<IActionResult> Get(Guid id) =>
            Ok(await Mediator.Send(new GetRealPropertyByIdQuery() { Id = id }));


        [HttpPut("{id:Guid}")]
        [SourcePermissions(AppSource.RealProperties, PermissionProperty.Update)]
        public async Task<IActionResult> Update(Guid id, UpdateRealPropertyCommand command)
        {
            if (id != command.Id)
                return BadRequest();
            return Ok(await Mediator.Send(command));
        }

        [HttpDelete("{id:Guid}")]
        [SourcePermissions(AppSource.RealProperties, PermissionProperty.Delete)]
        public async Task<IActionResult> Delete(Guid id) =>
            Ok(await Mediator.Send(new DeleteRealPropertyCommand()
            {
                Id = id
            }));

    }
}
