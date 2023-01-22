using Application.Roles.Commands.Requests;
using Application.Roles.Queries.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[Route("[controller]")]
public class RolesController : ApiControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get() =>
        Ok(await Mediator.Send(new GetRolesQuery()));

    [HttpGet("{id:Guid}")]
    public async Task<IActionResult> Get(Guid id) =>
        Ok(await Mediator.Send(new GetRoleByIdQuery(id)));

    [HttpPost]
    public async Task<IActionResult> Create(string name) =>
        Ok(await Mediator.Send(new CreateRoleCommand(name)));

    [HttpPut("{id:Guid}")]
    public async Task<IActionResult> Update(Guid id, UpdateRoleCommand command)
    {
        if (id != command.Id)
            return BadRequest();
        return Ok(await Mediator.Send(command));
    }

    [HttpDelete("{id:Guid}")]
    public async Task<IActionResult> Delete(Guid id) =>
        Ok(await Mediator.Send(new DeleteRoleCommand(id)));

    [HttpDelete()]
    public async Task<IActionResult> DeleteMany(DeleteManyRolesCommand command) =>
        Ok(await Mediator.Send(command));
}
