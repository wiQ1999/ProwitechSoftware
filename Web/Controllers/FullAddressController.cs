
using Application.BuildingAddresses.Commands.Requests;
using Application.BuildingAddresses.DTOs;
using Application.BuildingAddresses.Queries.Requests;
using Application.PropertyManagers.Commands.Requests;
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

        //[HttpPost]
        //[HttpPost]
        //public async Task<IActionResult> Create(CreatePropertyManagerCommand command)
        //{
        //    return Ok(await Mediator.Send(command));
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
    
//}
