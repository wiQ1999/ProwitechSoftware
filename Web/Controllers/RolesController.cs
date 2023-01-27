using Application.Roles.Commands.Requests;
using Application.Roles.Queries.Requests;
using Infrastructure.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using Web.Authorization;

namespace Web.Controllers;

[Route("[controller]")]
public class RolesController : ApiControllerBase
{
    [HttpGet]
    [SourcePermissions(AppSource.Roles, PermissionProperty.Read)]
    public async Task<IActionResult> Get() =>
        Ok(await Mediator.Send(new GetRolesQuery()));

    [HttpGet("{id:Guid}")]
    [SourcePermissions(AppSource.Roles, PermissionProperty.Read)]
    public async Task<IActionResult> Get(Guid id) =>
        Ok(await Mediator.Send(new GetRoleByIdQuery(id)));

    [HttpPost]
    [SourcePermissions(AppSource.Roles, PermissionProperty.Create)]
    public async Task<IActionResult> Create(string name) =>
        Ok(await Mediator.Send(new CreateRoleCommand(name)));

    [HttpPut("{id:Guid}")]
    [SourcePermissions(AppSource.Roles, PermissionProperty.Update)]
    public async Task<IActionResult> Update(Guid id, UpdateRoleCommand command)
    {
        if (id != command.Id)
            return BadRequest();
        return Ok(await Mediator.Send(command));
    }

    [HttpDelete("{id:Guid}")]
    [SourcePermissions(AppSource.Roles, PermissionProperty.Delete)]
    public async Task<IActionResult> Delete(Guid id) =>
        Ok(await Mediator.Send(new DeleteRoleCommand(id)));

    [HttpDelete()]
    [SourcePermissions(AppSource.Roles, PermissionProperty.Delete)]
    public async Task<IActionResult> DeleteMany(DeleteManyRolesCommand command) =>
        Ok(await Mediator.Send(command));
}
