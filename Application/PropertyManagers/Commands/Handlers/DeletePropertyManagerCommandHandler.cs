using Application.PropertyManagers.Commands.Requests;
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
    public class DeletePropertyManagerCommandHandler : IRequestHandler<DeletePropertyManagerCommand>
    {
        private readonly IPropertyManagerRepository _propertyManagerRepository;
        private readonly IFullAddressRepository _fullAddressRepository;

        public DeletePropertyManagerCommandHandler(IPropertyManagerRepository propertyManagerRepository, IFullAddressRepository fullAddressRepository)
        {
            _propertyManagerRepository = propertyManagerRepository;
            _fullAddressRepository = fullAddressRepository;
        }

        public async Task<Unit> Handle(DeletePropertyManagerCommand request, CancellationToken cancellationToken)
        {
            PropertyManager pm = await _propertyManagerRepository.GetAsync(request.Id, cancellationToken);
            if(pm!=null && pm.FullAddress != null)
            {
                await _fullAddressRepository.DeleteAsync(pm.FullAddressId.Value, cancellationToken);
            }
            await _propertyManagerRepository.DeleteAsync(request.Id, cancellationToken);
            return Unit.Value;
        }
    }
}
