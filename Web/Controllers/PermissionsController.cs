using Application.Permissions.Commands.Requests;
using Application.Permissions.Queries.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class PermissionsController : ApiControllerBase
{
    [HttpGet("{id:Guid}")]
    public async Task<IActionResult> Get(Guid id) =>
        Ok(await Mediator.Send(new GetUserPermissionsQuery(id)));

    [HttpPut("{id:Guid}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] UpdateUserPermissionsCommand command)
    {
        if (id != command.Id)
            return BadRequest();
        return Ok(await Mediator.Send(command));
    }
}
