using Application.Permissions.Commands.Requests;
using Application.Permissions.Queries.Requests;
using Infrastructure.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using Web.Authorization;

namespace Web.Controllers;

[Route("[controller]")]
public class PermissionsController : ApiControllerBase
{
    [HttpGet("Role/{roleId:Guid}")]
    [SourcePermissions(AppSource.Permissions, PermissionProperty.Read)]
    public async Task<IActionResult> GetForRole(Guid roleId) =>
        Ok(await Mediator.Send(new GetRolePermissionsQuery(roleId)));

    [HttpPost("Role/{roleId:Guid}")]
    [SourcePermissions(AppSource.Permissions, new[] { PermissionProperty.Create, PermissionProperty.Update })]
    public async Task<IActionResult> AddOrUpdateForRole(Guid roleId, CreateOrUpdateRolePermissionsCommand command)
    {
        if (roleId != command.RoleId)
            return BadRequest();
        return Ok(await Mediator.Send(command));
    }

    [HttpGet("User/{userId:Guid}")]
    [SourcePermissions(AppSource.Permissions, PermissionProperty.Read)]
    public async Task<IActionResult> GetForUser(Guid userId) =>
        Ok(await Mediator.Send(new GetUserPermissionsQuery(userId)));

    [HttpPost("User/{userId:Guid}")]
    [SourcePermissions(AppSource.Permissions, new[] { PermissionProperty.Create, PermissionProperty.Update })]
    public async Task<IActionResult> AddOrUpdateForRole(Guid userId, CreateOrUpdateUserPermissionsCommand command)
    {
        if (userId != command.UserId)
            return BadRequest();
        return Ok(await Mediator.Send(command));
    }
}
