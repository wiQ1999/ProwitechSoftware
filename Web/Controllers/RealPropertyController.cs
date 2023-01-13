using Application.RealProperties.Commands.Requests;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Web.Controllers
{
    [Route("[controller]")]
    public class RealPropertyController : ApiControllerBase
    {
        //[HttpGet]
        //public async Task<IActionResult> Get() =>
        //        Ok(await Mediator.Send(new GetAllInspectionTasksQuery()));

        [HttpPost]
        public async Task<IActionResult> Create(CreateRealPropertyCommand command) =>
            Ok(await Mediator.Send(command));

        //[HttpGet("{id:Guid}")]
        //public async Task<IActionResult> Get(Guid id) =>
        //    Ok(await Mediator.Send(new GetInspectionTaskByIdQuery() { Id = id }));


        //[HttpPut("{id:Guid}")]
        //public async Task<IActionResult> Update(Guid id, UpdateInspectionTaskCommand command)
        //{
        //    if (id != command.Id)
        //        return BadRequest();
        //    return Ok(await Mediator.Send(command));
        //}

        //[HttpDelete("{id:Guid}")]
        //public async Task<IActionResult> Delete(Guid id) =>
        //    Ok(await Mediator.Send(new DeleteInspectionTaskCommand
        //    {
        //        Id = id
        //    }));
        //[HttpGet("performerTasks/{id:Guid}")]
        //public async Task<IActionResult> GetInspectionTasksOfParticularPerformer(Guid id) =>
        //    Ok(await Mediator.Send(new GetInspectionTasksOfParticularPerformerQuery() { Id = id }));

        //[HttpGet("performerTasks/{id:Guid}/status/{status}")]
        //public async Task<IActionResult> GetInspectionTasksOfParticularPerformerAndStatus(Guid id, string status) =>
        //    Ok(await Mediator.Send(
        //        new GetInspectionTasksOfParticularPerformerAndStatusQuery()
        //        {
        //            Id = id,
        //            Status = status
        //        }
        //        ));
    }
}
