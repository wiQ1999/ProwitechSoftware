using Application.PropertyManagers.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
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

        public DeletePropertyManagerCommandHandler(IPropertyManagerRepository propertyManagerRepository)
        {
            _propertyManagerRepository = propertyManagerRepository;
        }

        public async Task<Unit> Handle(DeletePropertyManagerCommand request, CancellationToken cancellationToken)
        {
            await _propertyManagerRepository.DeleteAsync(request.Id,cancellationToken);
            return Unit.Value;
        }
    }
}
