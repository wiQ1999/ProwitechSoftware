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

        [HttpGet]
        public async Task<IActionResult> Get() =>
                Ok(await Mediator.Send(new GetAllInspectionProtocolsQuery()));

        [HttpGet("buildingProtocols/{id:Guid}")]
        public async Task<IActionResult> GetBuildingProtocols(Guid id) =>
                Ok(await Mediator.Send(new GetBuildingProtocolsQuery()
                {
                    BuildingId = id
                }));

        [HttpGet("taskProtocols/{id:Guid}")]
        public async Task<IActionResult> GetTaskProtocols(Guid id) =>
                Ok(await Mediator.Send(new GetTaskProtocolsQuery()
                {
                    InspectionTaskId = id
                }));
        [HttpGet("performerProtocols/{id:Guid}")]
        public async Task<IActionResult> GetPerformerProtocols(Guid id) =>
                Ok(await Mediator.Send(new GetPerformerProtocolsQuery()
                {
                    PerformerId = id
                }));

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> Get(Guid id) =>
            Ok(await Mediator.Send(new GetInspectionProtocolByIdQuery { Id = id }));

        [HttpGet("biggestProtocolNumber/{date}")]
        public async Task<IActionResult> GetBiggestProtocolNumber(string date) =>
            Ok(await Mediator.Send(new GetBiggestProtocolNumberQuery { DateTimeStr = date }));

        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> Delete(Guid id) =>
           Ok(await Mediator.Send(new DeleteInspectionProtocolCommand
           {
               Id = id
           }));
    }
}
