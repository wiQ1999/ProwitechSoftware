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
    public async Task<IActionResult> AddOrUpdateForRole(Guid roleId, CreateOrUpdateUserPermissionsCommand command)
    {
        if (roleId != command.UserId)
            return BadRequest();
        return Ok(await Mediator.Send(command));
    }

    [HttpGet("User/{userId:Guid}")]
    public async Task<IActionResult> GetForUser(Guid userId, Guid? userRoleId) =>
        Ok(await Mediator.Send(new GetUserPermissionsQuery(userId, userRoleId)));

    
}
