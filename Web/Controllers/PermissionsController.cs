using Application.Permissions.Commands.Requests;
using Application.Permissions.Queries.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[Route("[controller]")]
public class PermissionsController : ApiControllerBase
{
    [HttpGet("Role/{roleId:Guid}")]
    public async Task<IActionResult> GetForRole(Guid roleId) =>
        Ok(await Mediator.Send(new GetRolePermissionsQuery(roleId)));

    [HttpPost("Role/{roleId:Guid}")]
    public async Task<IActionResult> AddOrUpdateForRole(Guid roleId, CreateOrUpdateRolePermissionsCommand command)
    {
        if (roleId != command.RoleId)
            return BadRequest();
        return Ok(await Mediator.Send(command));
    }

    [HttpGet("User/{userId:Guid}")]
    public async Task<IActionResult> GetForUser(Guid userId) =>
        Ok(await Mediator.Send(new GetUserPermissionsQuery(userId)));

    [HttpPost("User/{userId:Guid}")]
    public async Task<IActionResult> AddOrUpdateForRole(Guid userId, CreateOrUpdateUserPermissionsCommand command)
    {
        if (userId != command.UserId)
            return BadRequest();
        return Ok(await Mediator.Send(command));
    }
}
