
using Application.BuildingAddresses.Commands.Requests;
using Application.BuildingAddresses.DTOs;
using Application.BuildingAddresses.Queries.Requests;
using Application.FullAddresses.Commands.Requests;
using Application.FullAddresses.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("[controller]")]
    public class FullAddressController:ApiControllerBase
    {
        //[HttpGet]
        //public async Task<IActionResult> Get() =>
        //    Ok(await Mediator.Send(new GetAllFullAddressesQuery));
        
        //[HttpGet("{id:Guid}")]
        //public async Task<IActionResult> Get(Guid id) =>
        //    Ok(await Mediator.Send(new GetFullAddressByIdQuery(id)));

        [HttpPost]
        public async Task<IActionResult> Create(CreateFullAddressCommand command)
        {
            if (command.LocalInfo != null)
            {
                var localInfoId = await Mediator.Send(command.LocalInfo);
                command.LocalInfo.Id = localInfoId;
            }
            return Ok(await Mediator.Send(command));
        }
        //[HttpPut("{id:Guid}")]
        //public async Task<IActionResult> Update(Guid id, [FromBody] UpdateBuildingAddressDTO address, bool? force, bool? onlyAddress)
        //{
        //    bool forceNotNull = force.HasValue ? force.Value : false;
        //    bool onlyAddressNotNull = onlyAddress.HasValue ? onlyAddress.Value : false;
        //    return Ok(await Mediator.Send(new UpdateBuildingAddressCommand
        //    {
        //        Id = id,
        //        AddressDTO = address,
        //        UpdateWithNotAccurateCoords = forceNotNull,
        //        UpdateWithoutCoords = onlyAddressNotNull
        //    }));
        //}
        //[HttpPut("postalCode/{id:Guid}")]
        //public async Task<IActionResult> ChangePostalCode(Guid id, [FromBody] UpdatePostalCodeCommand command)
        //{
        //    if (id != command.Id)
        //        return BadRequest();
        //    return Ok(await Mediator.Send(command));
        //}

    }
    
}
