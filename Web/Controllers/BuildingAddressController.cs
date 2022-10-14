using Application.BuildingAddresses.Commands.Requests;
using Application.BuildingAddresses.DTOs;
using Application.BuildingAddresses.Queries.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")] // mapuje nazwe z nazwy kontrolera
    public class BuildingAddressController : ApiControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get() =>
           Ok(await Mediator.Send(new GetBuildingAddressesQuery()));

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> Get(Guid id) =>
            Ok(await Mediator.Send(new GetBuildingAddressByIdQuery(id)));

        [HttpPost]
        public async Task<IActionResult> Create(AddBuildingAddressDTO addressDTO, bool? force)
        {
            bool forceNotNull = force.HasValue ? force.Value : false;
            return Ok(await Mediator.Send(new CreateBuildingAddressCommand
            {
                AddressDTO = addressDTO,
                Force = forceNotNull
            }));
        }
    }
}
