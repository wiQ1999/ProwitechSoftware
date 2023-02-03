using Application.BuildingAddresses.Commands.Requests;
using Application.BuildingAddresses.DTOs;
using Application.BuildingAddresses.Queries.Requests;
using Application.PropertyManagers.Commands.Requests;
using Infrastructure.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using Web.Authorization;

namespace Web.Controllers
{
    [Route("[controller]")]
    public class BuildingAddressController : ApiControllerBase
    {
        [HttpGet]
        [SourcePermissions(AppSource.BuildingAddresses, PermissionProperty.Read)]
        public async Task<IActionResult> Get() =>
           Ok(await Mediator.Send(new GetAllBuildingAddressesQuery()));

        [HttpGet("{id:Guid}")]
        [SourcePermissions(AppSource.BuildingAddresses, PermissionProperty.Read)]
        public async Task<IActionResult> Get(Guid id) =>
            Ok(await Mediator.Send(new GetBuildingAddressByIdQuery(id)));

        [HttpPost]
        [SourcePermissions(AppSource.BuildingAddresses, PermissionProperty.Create)]
        public async Task<IActionResult> Create(AddBuildingAddressDTO addressDTO, bool? force, bool? onlyAddress)
        {
            bool forceNotNull = force.HasValue ? force.Value : false;
            bool onlyAddressNotNull=onlyAddress.HasValue ? onlyAddress.Value : false;
            return Ok(await Mediator.Send(new CreateBuildingAddressCommand
            {
                AddressDTO = addressDTO,
                ForceDespiteCoordIssue = forceNotNull,
                AddAddressWithoutCoordinates=onlyAddressNotNull
            }));
        }
        [HttpPut("{id:Guid}")]
        [SourcePermissions(AppSource.BuildingAddresses, PermissionProperty.Update)]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateBuildingAddressDTO address, bool? force, bool? onlyAddress)
        {
            bool forceNotNull = force.HasValue ? force.Value : false;
            bool onlyAddressNotNull = onlyAddress.HasValue ? onlyAddress.Value : false;
            return Ok(await Mediator.Send(new UpdateBuildingAddressCommand
            {
                Id = id,
                AddressDTO = address,
                UpdateWithNotAccurateCoords = forceNotNull,
                UpdateWithoutCoords = onlyAddressNotNull
            }));
        }
        [HttpPut("postalCode/{id:Guid}")]
        [SourcePermissions(AppSource.BuildingAddresses, PermissionProperty.Update)]
        public async Task<IActionResult> ChangePostalCode(Guid id, [FromBody] UpdatePostalCodeCommand command)
        {
            if (id != command.Id)
                return BadRequest();
            return Ok(await Mediator.Send(command));
        }
        [HttpDelete("{id:Guid}")]
        [SourcePermissions(AppSource.BuildingAddresses, PermissionProperty.Delete)]
        public async Task<IActionResult> Delete(Guid id) =>
            Ok(await Mediator.Send(new DeleteBuildingAddressCommand() { Id = id }));

    }
}
