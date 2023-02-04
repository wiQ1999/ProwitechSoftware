using Application.Users.Commands.Requests;
using Application.Users.Queries.Requests;
using Infrastructure.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using Web.Authorization;

namespace Web.Controllers;

[Route("[controller]")]
public class UsersController : ApiControllerBase
{
    [HttpGet]
    [SourcePermissions(AppSource.Users, PermissionProperty.Read)]
    public async Task<IActionResult> Get() =>
        Ok(await Mediator.Send(new GetUsersQuery()));

    [HttpGet("{id:Guid}")]
    [SourcePermissions(AppSource.Users, PermissionProperty.Read)]
    public async Task<IActionResult> Get(Guid id) =>
        Ok(await Mediator.Send(new GetUserByIdQuery(id)));

    [HttpPost]
    [SourcePermissions(AppSource.Users, PermissionProperty.Create)]
    public async Task<IActionResult> Create(CreateUserCommand command) =>
        Ok(await Mediator.Send(command));

    [HttpPut("{id:Guid}")]
    [SourcePermissions(AppSource.Users, PermissionProperty.Update)]
    public async Task<IActionResult> Update(Guid id, UpdateUserCommand command)
    {
        if (id != command.Id)
            return BadRequest();
        return Ok(await Mediator.Send(command));
    }

    [HttpPut("Security/{id:Guid}")]
    [SourcePermissions(AppSource.Users, PermissionProperty.Update)]
    public async Task<IActionResult> ChangePassword(Guid id, ChangeUserPasswordCommand command)
    {
        if (id != command.Id)
            return BadRequest();
        return Ok(await Mediator.Send(command));
    }

    [HttpDelete("{id:Guid}")]
    [SourcePermissions(AppSource.Users, PermissionProperty.Delete)]
    public async Task<IActionResult> Delete(Guid id) =>
        Ok(await Mediator.Send(new DeleteUserCommand(id)));

    [HttpDelete]
    [SourcePermissions(AppSource.Users, PermissionProperty.Delete)]
    public async Task<IActionResult> DeleteMany(DeleteManyUsersCommand command) =>
        Ok(await Mediator.Send(command));
}
