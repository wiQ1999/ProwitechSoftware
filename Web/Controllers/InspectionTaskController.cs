﻿using Application.Buildings.Commands.Requests;
using Application.Buildings.Queries.Requests;
using Application.InspectionTasks.Commands.Requests;
using Application.InspectionTasks.Queries.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("[controller]")]
    public class InspectionTaskController : ApiControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get() =>
                Ok(await Mediator.Send(new GetAllInspectionTasksQuery()));

        [HttpPost]
        public async Task<IActionResult> Create(CreateInspectionTaskCommand command) =>
            Ok(await Mediator.Send(command));

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> Get(Guid id) =>
            Ok(await Mediator.Send(new GetInspectionTaskByIdQuery() { Id = id }));


        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> Update(Guid id, UpdateInspectionTaskCommand command)
        {
            if (id != command.Id)
                return BadRequest();
            return Ok(await Mediator.Send(command));
        }

        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> Delete(Guid id) =>
            Ok(await Mediator.Send(new DeleteInspectionTaskCommand
            {
                Id = id
            }));

    }
}
