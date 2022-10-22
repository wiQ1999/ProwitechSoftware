using Application.PropertyManagers.Commands.Requests;
using Application.PropertyManagers.Queries.Requests;
using Application.Roles.Commands.Requests;
using Application.Roles.Queries.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("[controller]")]
    public class PropertyManagerController : ApiControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(CreatePropertyManagerCommand command)
        {
            return Ok(await Mediator.Send(command));
        }
        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> Update (Guid id, UpdatePropertyManagerCommand command)
        {
            if (id != command.Id)
                return BadRequest();
            return Ok(await Mediator.Send(command));
        }
        [HttpGet]
        public async Task<IActionResult> Get() =>
            Ok(await Mediator.Send(new GetAllPropertyManagersQuery()));
    }

    //[HttpGet]
    //public async Task<IActionResult> Get() =>
    //    Ok(await Mediator.Send(new GetRolesQuery()));

    //[HttpGet("{id:Guid}")]
    //public async Task<IActionResult> Get(Guid id) =>
    //    Ok(await Mediator.Send(new GetRoleByIdQuery(id)));

    //[HttpPost]
    //public async Task<IActionResult> Create(string name) =>
    //    Ok(await Mediator.Send(new CreateRoleCommand(name)));

    //[HttpPut("{id:Guid}")]
    //public async Task<IActionResult> Update(Guid id, [FromBody] UpdateRoleCommand command)
    //{
    //    if (id != command.Id)
    //        return BadRequest();
    //    return Ok(await Mediator.Send(command));
    //}

    //[HttpDelete("{id:Guid}")]
    //public async Task<IActionResult> Delete(Guid id) =>
    //    Ok(await Mediator.Send(new DeleteRoleCommand(id)));
}
