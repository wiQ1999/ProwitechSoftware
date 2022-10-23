﻿
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
            var faDTO = request.FullAddressesDTO;

            var baFromDB = await _buildingAddressRepository.GetAsync(faDTO.BuildingAddressId, cancellationToken);
            if (baFromDB == null)
                throw new Exception($"W bazie danych nie ma adresu budynku o id: {faDTO.BuildingAddressId}");
            var fullAddres = new FullAddress()
            {
                BuildingAddressId = faDTO.BuildingAddressId,
                LocalNumber = faDTO.LocalNumber,
                StaircaseNumber = faDTO.StaircaseNumber
            };

            var fullAddressId = await _fullAddressRepository.AddAsync(fullAddres, cancellationToken);
            var faFromDB = await _fullAddressRepository.GetAsync(fullAddressId, cancellationToken);//SPRAWDZIĆ BEZ TEGO

            PropertyManager propertyManager = new()
            {
                Name = request.Name,
                PhoneNumber = request.PhoneNumber,
                FullAddressId = faFromDB.Id,
                
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
