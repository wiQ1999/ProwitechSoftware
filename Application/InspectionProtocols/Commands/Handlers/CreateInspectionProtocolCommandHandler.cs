using Application.InspectionProtocols.Commands.Requests;
using AutoMapper;
using Infrastructure.Interfaces.UnitOfWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InspectionProtocols.Commands.Handlers
{
    public class CreateInspectionProtocolCommandHandler : IRequestHandler<CreateInspectionProtocolCommand, Guid>
    {
        private readonly IRepositoriesUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateInspectionProtocolCommandHandler(IRepositoriesUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateInspectionProtocolCommand request, CancellationToken cancellationToken)
        {
            Guid id = Guid.NewGuid();
            return id;
        }
    }
}
