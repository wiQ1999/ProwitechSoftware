using Application.InspectionProtocols.Commands.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("[controller]")]
    public class InspectionProtocolController: ApiControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(CreateInspectionProtocolCommand command) =>
            Ok(await Mediator.Send(command));
    }
}
