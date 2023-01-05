
using Application.PropertyManagers.Commands.Requests;
using Application.Roles.Commands.Requests;
using AutoMapper;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PropertyManagers.Commands.Handlers
{
    public class CreatePropertyManagerCommandHandler : IRequestHandler<CreatePropertyManagerCommand, Guid>
    {
        private readonly IPropertyManagerRepository _propertyManagerRepository;
        private readonly IFullAddressRepository _fullAddressRepository;
        private readonly IBuildingAddressRepository _buildingAddressRepository;

        public CreatePropertyManagerCommandHandler(IPropertyManagerRepository propertyManagerRepository, IFullAddressRepository fullAddressRepository, IBuildingAddressRepository buildingAddressRepository)
        {
            _propertyManagerRepository = propertyManagerRepository;
            _fullAddressRepository = fullAddressRepository;
            _buildingAddressRepository = buildingAddressRepository;
        }

        public async Task<Guid> Handle(CreatePropertyManagerCommand request, CancellationToken cancellationToken)
        {
            var faDTO = request.FullAddressDTO;

            var baFromDB = await _buildingAddressRepository.GetAsync(faDTO.BuildingAddressId, cancellationToken);
            if (baFromDB == null)
                throw new Exception($"W bazie danych nie ma adresu budynku o id: {faDTO.BuildingAddressId}");
            var fullAddres = new FullAddress()
            {
                BuildingAddressId = faDTO.BuildingAddressId,
                LocalNumber = faDTO.LocalNumber,
                StaircaseNumber = faDTO.StaircaseNumber
            };
            Guid fullAddressId;
            var faFromDB = await _fullAddressRepository.FindFullAddress(fullAddres, cancellationToken);
            if(faFromDB == null)
            {
                fullAddressId = await _fullAddressRepository.AddAsync(fullAddres, cancellationToken);
            }
            else
            {
                fullAddressId = faFromDB.Id;
            }


            PropertyManager propertyManager = new()
            {
                Name = request.Name,
                PhoneNumber = request.PhoneNumber,
                FullAddressId = fullAddressId,
                
            };
            return await _propertyManagerRepository.AddAsync(propertyManager, cancellationToken);
        }
    }

    //public class CreateRoleCommandHandler : IRequestHandler<CreateRoleCommand, Guid>
    //{
    //    private readonly IRoleRepository _roleRepository;

    //    public CreateRoleCommandHandler(IRoleRepository roleRepository)
    //    {
    //        _roleRepository = roleRepository;
    //    }

    //    public async Task<Guid> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
    //    {
    //        Role role = new() { Name = request.Name };
    //        return await _roleRepository.CreateRoleAsync(role, cancellationToken);
    //    }
    //}
}
