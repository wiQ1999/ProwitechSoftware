using Application.Users.Commands.Requests;
using Application.Users.Queries.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

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
    public async Task<IActionResult> Create([FromBody] CreateUserCommand command) =>
        Ok(await Mediator.Send(command));

    [HttpPut("{id:Guid}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] UpdateUserCommand command)
    {
        if (id != command.Id)
            return BadRequest();
        return Ok(await Mediator.Send(command));
    }

    [HttpPut("security/{id:Guid}")]
    public async Task<IActionResult> ChangePassword(Guid id, [FromBody] ChangeUserPasswordCommand command)
    {
        if (id != command.Id)
            return BadRequest();
        return Ok(await Mediator.Send(command));
    }

    [HttpDelete("{id:Guid}")]
    public async Task<IActionResult> Delete(Guid id) =>
        Ok(await Mediator.Send(new DeleteUserCommand(id)));
}
