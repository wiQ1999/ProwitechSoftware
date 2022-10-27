using Application.Users.Commands.Requests;
using Application.Users.Queries.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[Authorize]
[Route("[controller]")]
public class UsersController : ApiControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get() =>
        Ok(await Mediator.Send(new GetUsersQuery()));

    [HttpGet("{id:Guid}")]
    public async Task<IActionResult> Get(Guid id) =>
        Ok(await Mediator.Send(new GetUserByIdQuery(id)));

    [HttpPost]
    public async Task<IActionResult> Create(CreateUserCommand command) =>
        Ok(await Mediator.Send(command));

    [HttpPut("{id:Guid}")]
    public async Task<IActionResult> Update(Guid id, UpdateUserCommand command)
    {
        if (id != command.Id)
            return BadRequest();
        return Ok(await Mediator.Send(command));
    }

    [HttpPut("Security/{id:Guid}")]
    public async Task<IActionResult> ChangePassword(Guid id, ChangeUserPasswordCommand command)
    {
        if (id != command.Id)
            return BadRequest();
        return Ok(await Mediator.Send(command));
    }

    [HttpDelete("{id:Guid}")]
    public async Task<IActionResult> Delete(Guid id) =>
        Ok(await Mediator.Send(new DeleteUserCommand(id)));
}
