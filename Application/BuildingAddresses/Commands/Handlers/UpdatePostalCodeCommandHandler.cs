using Application.BuildingAddresses.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BuildingAddresses.Commands.Handlers
{
    public class UpdatePostalCodeCommandHandler : IRequestHandler<UpdatePostalCodeCommand>
    {
        private readonly IBuildingAddressRepository _buildingAddressRepository;

        public UpdatePostalCodeCommandHandler(IBuildingAddressRepository buildingAddressRepository)
        {
            _buildingAddressRepository = buildingAddressRepository;
        }

        public async Task<Unit> Handle(UpdatePostalCodeCommand request, CancellationToken cancellationToken)
        {
            var buildingAddressFromDB = await _buildingAddressRepository.GetAsync(request.Id, cancellationToken);
            if(buildingAddressFromDB == null)
                throw new Exception($"Nie znaleziono adresu budynku o identyfikatorze {request.Id}.");
            buildingAddressFromDB.PostalCode = request.PostalCode;
            await _buildingAddressRepository.UpdateBuildingAddressAsync(buildingAddressFromDB, cancellationToken);
            return Unit.Value;
        }
    }
}
