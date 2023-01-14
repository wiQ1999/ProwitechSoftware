using Application.PropertyManagers.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Interfaces.UnitOfWork;
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
        private readonly IRepositoriesUnitOfWork _unitOfWork;

        public DeletePropertyManagerCommandHandler(IRepositoriesUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(DeletePropertyManagerCommand request, CancellationToken cancellationToken)
        {
            PropertyManager pm = await _unitOfWork.PropertyManagerRepository.GetAsync(request.Id, cancellationToken);
            if(pm!=null && pm.FullAddress != null)
            {
                await _unitOfWork.FullAddressRepository.DeleteAsync(pm.FullAddressId.Value, cancellationToken);
                await _unitOfWork.SaveChangesAsync(cancellationToken);
            }
            await _unitOfWork.PropertyManagerRepository.DeleteAsync(request.Id, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
