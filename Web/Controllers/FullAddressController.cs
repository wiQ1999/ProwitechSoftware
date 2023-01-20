
using Application.BuildingAddresses.Commands.Requests;
using Application.BuildingAddresses.DTOs;
using Application.BuildingAddresses.Queries.Requests;
using Application.FullAddresses.Commands.Requests;
using Application.PropertyManagers.Commands.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("[controller]")]
    public class FullAddressController : ApiControllerBase
    {
        
        //[HttpPost]
        //public async Task<IActionResult> Create(CreateFullAddressCommand command)
        //{
        //    return Ok(await Mediator.Send(command));
        //}
        
    }
}
