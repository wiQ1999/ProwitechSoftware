using Application.Buildings.Commands.Requests;
using Application.Buildings.Queries.Requests;
using Application.InspectionTasks.Commands.Requests;
using Application.InspectionTasks.Queries.Requests;
using Infrastructure.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using Web.Authorization;

namespace Web.Controllers
{
    [Route("[controller]")]
    public class InspectionTaskController : ApiControllerBase
    {
        [HttpGet]
        [SourcePermissions(AppSource.InspectionTasks, PermissionProperty.Read)]
        public async Task<IActionResult> Get() =>
                Ok(await Mediator.Send(new GetAllInspectionTasksQuery()));

        [HttpPost]
        [SourcePermissions(AppSource.InspectionTasks, PermissionProperty.Create)]
        public async Task<IActionResult> Create(CreateInspectionTaskCommand command) =>
            Ok(await Mediator.Send(command));

        [HttpGet("{id:Guid}")]
        [SourcePermissions(AppSource.InspectionTasks, PermissionProperty.Read)]
        public async Task<IActionResult> Get(Guid id) =>
            Ok(await Mediator.Send(new GetInspectionTaskByIdQuery() { Id = id }));


        [HttpPut("{id:Guid}")]
        [SourcePermissions(AppSource.InspectionTasks, PermissionProperty.Update)]
        public async Task<IActionResult> Update(Guid id, UpdateInspectionTaskCommand command)
        {
            if (id != command.Id)
                return BadRequest();
            return Ok(await Mediator.Send(command));
        }
        [HttpPut("{id:Guid}/changeStatusToInProgress")]
        [SourcePermissions(AppSource.InspectionTasks, PermissionProperty.Update)]
        public async Task<IActionResult> changeStatusToInProgress(Guid id, ChangeTaskStatusCommand command)
        {
            if (id != command.Id)
                return BadRequest();
            return Ok(await Mediator.Send(command));
        }

        [HttpDelete("{id:Guid}")]
        [SourcePermissions(AppSource.InspectionTasks, PermissionProperty.Delete)]
        public async Task<IActionResult> Delete(Guid id) =>
            Ok(await Mediator.Send(new DeleteInspectionTaskCommand
            {
                Id = id
            }));
        [HttpGet("performerTasks/{id:Guid}")]
        [SourcePermissions(AppSource.InspectionTasks, PermissionProperty.Read)]
        public async Task<IActionResult> GetInspectionTasksOfParticularPerformer(Guid id) =>
            Ok(await Mediator.Send(new GetInspectionTasksOfParticularPerformerQuery() { Id = id }));

        [HttpGet("{id:Guid}/propertiesWithoutProtocols")]
        [SourcePermissions(AppSource.InspectionTasks, PermissionProperty.Read)]
        public async Task<IActionResult> GetInspectionTaskPropertiesWithoutProtocols(Guid id) =>
            Ok(await Mediator.Send(new GetTaskRealPropertiesWhichDontHaveProtocolsQuery { TaskId = id }));

        [HttpGet("performerTasks/{id:Guid}/status/{status}")]
        [SourcePermissions(AppSource.InspectionTasks, PermissionProperty.Read)]
        public async Task<IActionResult> GetInspectionTasksOfParticularPerformerAndStatus(Guid id, string status) =>
            Ok(await Mediator.Send(
                new GetInspectionTasksOfParticularPerformerAndStatusQuery()
                {
                    Id = id,
                    Status = status
                }
                ));

    }
}
