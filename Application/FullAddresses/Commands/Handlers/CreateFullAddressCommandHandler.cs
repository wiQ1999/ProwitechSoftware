using Application.BuildingAddresses.Commands.Requests;
using Application.FullAddresses.Commands.Requests;
using Application.Responses;
using AutoMapper;
using Infrastructure.GoogleAPI;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using Infrastructure.Responses.BuildingAddressController;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.FullAddresses.Commands.Handlers
{
    public class CreateFullAddressCommandHandler : IRequestHandler<CreateFullAddressCommand, Guid>
    {
        private readonly IFullAddressRepository _fullAddressRepository;

        public CreateFullAddressCommandHandler(IFullAddressRepository fullAddressRepository)
        {
            _fullAddressRepository = fullAddressRepository;
        }

        public Task<Guid> Handle(CreateFullAddressCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        //public async Task<Guid> Handle(CreateFullAddressCommand request, CancellationToken cancellationToken)
        //{
        //    FullAddress fullAddress = new FullAddress();
        //    fullAddress.BuildingAddressId = request.BuildingAddressId;
        //    if(request.LocalInfo != null)
        //    {
        //        fullAddress.LocalInfoId = request.LocalInfo.Id;
        //    }
        //    return await _fullAddressRepository.AddAsync(fullAddress, cancellationToken);
        //}
    }
    
    
}
