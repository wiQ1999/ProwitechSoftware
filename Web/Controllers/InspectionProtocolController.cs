using Application.InspectionProtocols.Commands.Requests;
using Application.InspectionProtocols.Queries.Requests;
using Application.InspectionTasks.Queries.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("[controller]")]
    public class InspectionProtocolController: ApiControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(CreateInspectionProtocolCommand command) =>
            Ok(await Mediator.Send(command));

        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> Update(Guid id, UpdateInspectionProtocolCommand command)
        {
            if (id != command.Id)
                return BadRequest();
            return Ok(await Mediator.Send(command));
        }
        [HttpGet("biggestProtocolNumber/{date}")]
        public async Task<IActionResult> GetInspectionTasksOfParticularPerformer(string date) =>
            Ok(await Mediator.Send(new GetBiggestProtocolNumberQuery { DateTimeStr = date }));
    }
}
