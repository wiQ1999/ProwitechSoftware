using Application.InspectionProtocols.Commands.Requests;
using Application.InspectionProtocols.Queries.Requests;
using Application.InspectionTasks.Queries.Requests;
using Infrastructure.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using Web.Authorization;

namespace Web.Controllers
{
    [Route("[controller]")]
    public class InspectionProtocolController: ApiControllerBase
    {
        [HttpPost]
        [SourcePermissions(AppSource.PersonalProtocols, PermissionProperty.Create)]
        public async Task<IActionResult> Create(CreateInspectionProtocolCommand command) =>
            Ok(await Mediator.Send(command));

        [HttpPut("{id:Guid}")]
        [SourcePermissions(AppSource.PersonalProtocols, PermissionProperty.Update)]
        public async Task<IActionResult> Update(Guid id, UpdateInspectionProtocolCommand command)
        {
            if (id != command.Id)
                return BadRequest();
            return Ok(await Mediator.Send(command));
        }

        [HttpGet]
        [SourcePermissions(AppSource.AllInspectionProtocols, PermissionProperty.Read)]
        public async Task<IActionResult> Get() =>
                Ok(await Mediator.Send(new GetAllInspectionProtocolsQuery()));

        [HttpGet("buildingProtocols/{id:Guid}")]
        [SourcePermissions(AppSource.AllInspectionProtocols, PermissionProperty.Read)]
        public async Task<IActionResult> GetBuildingProtocols(Guid id) =>
                Ok(await Mediator.Send(new GetBuildingProtocolsQuery()
                {
                    BuildingId = id
                }));

        [HttpGet("taskProtocols/{id:Guid}")]
        [SourcePermissions(AppSource.PersonalProtocols, PermissionProperty.Read)]
        public async Task<IActionResult> GetTaskProtocols(Guid id) =>
                Ok(await Mediator.Send(new GetTaskProtocolsQuery()
                {
                    InspectionTaskId = id
                }));
        [HttpGet("performerProtocols/{id:Guid}")]
        [SourcePermissions(AppSource.PersonalProtocols, PermissionProperty.Read)]
        public async Task<IActionResult> GetPerformerProtocols(Guid id) =>
                Ok(await Mediator.Send(new GetPerformerProtocolsQuery()
                {
                    PerformerId = id
                }));

        [HttpGet("{id:Guid}")]
        [SourcePermissions(AppSource.PersonalProtocols, PermissionProperty.Read)]
        public async Task<IActionResult> Get(Guid id) =>
            Ok(await Mediator.Send(new GetInspectionProtocolByIdQuery { Id = id }));

        [HttpGet("biggestProtocolNumber/{date}")]
        [SourcePermissions(AppSource.PersonalProtocols, PermissionProperty.Read)]
        public async Task<IActionResult> GetBiggestProtocolNumber(string date) =>
            Ok(await Mediator.Send(new GetBiggestProtocolNumberQuery { DateTimeStr = date }));

        [HttpDelete("{id:Guid}")]
        [SourcePermissions(AppSource.PersonalProtocols, PermissionProperty.Delete)]
        public async Task<IActionResult> Delete(Guid id) =>
           Ok(await Mediator.Send(new DeleteInspectionProtocolCommand
           {
               Id = id
           }));
    }
}
