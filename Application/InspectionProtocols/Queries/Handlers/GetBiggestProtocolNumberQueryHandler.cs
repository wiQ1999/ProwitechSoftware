
using Application.InspectionProtocols.Queries.Requests;
using Infrastructure.Interfaces.UnitOfWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InspectionProtocols.Queries.Handlers
{
    public class GetBiggestProtocolNumberQueryHandler : IRequestHandler<GetBiggestProtocolNumberQuery, string>
    {
        private readonly IRepositoriesUnitOfWork _unitOfWork;

        public GetBiggestProtocolNumberQueryHandler(IRepositoriesUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<string> Handle(GetBiggestProtocolNumberQuery request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.InspectionProtocolsRepository.GetTheBiggestProtocolNumber(request.DateTimeStr, cancellationToken);
        }
    }
}
