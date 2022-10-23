using Application.Buildings.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Buildings.Commands.Handlers
{
    public class CreateBuildingCommandHandler : IRequestHandler<CreateBuildingCommand, Guid>
    {
        private readonly IBuildingAddressRepository _buildingAddressRepository;
        private readonly IPropertyManagerRepository _propertyManagerRepository;
        private readonly IBuildingRepository _buildingRepository;

        public CreateBuildingCommandHandler(IBuildingAddressRepository buildingAddressRepository, IPropertyManagerRepository propertyManagerRepository, IBuildingRepository buildingRepository)
        {
            _buildingAddressRepository = buildingAddressRepository;
            _propertyManagerRepository = propertyManagerRepository;
            _buildingRepository = buildingRepository;
        }

        public Task<Guid> Handle(CreateBuildingCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
