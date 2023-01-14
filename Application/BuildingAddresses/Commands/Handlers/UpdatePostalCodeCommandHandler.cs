using Application.BuildingAddresses.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Interfaces.UnitOfWork;
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
        private readonly IRepositoriesUnitOfWork _unitOfWork;

        public UpdatePostalCodeCommandHandler(IRepositoriesUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdatePostalCodeCommand request, CancellationToken cancellationToken)
        {
            var buildingAddressFromDB = await _unitOfWork.BuildingAddressRepository.GetAsync(request.Id, cancellationToken);
            if(buildingAddressFromDB == null)
                throw new Exception($"Nie znaleziono adresu budynku o identyfikatorze {request.Id}.");
            buildingAddressFromDB.PostalCode = request.PostalCode;
            await _unitOfWork.BuildingAddressRepository.UpdateBuildingAddressAsync(buildingAddressFromDB, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
