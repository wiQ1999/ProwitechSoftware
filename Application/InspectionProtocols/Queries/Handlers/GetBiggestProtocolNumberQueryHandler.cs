
using Application.InspectionProtocols.DTOs;
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
    public class GetBiggestProtocolNumberQueryHandler : IRequestHandler<GetBiggestProtocolNumberQuery, BiggestNumberDTO>
    {
        private readonly IRepositoriesUnitOfWork _unitOfWork;

        public GetBiggestProtocolNumberQueryHandler(IRepositoriesUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<BiggestNumberDTO> Handle(GetBiggestProtocolNumberQuery request, CancellationToken cancellationToken)
        {
            var nr = await _unitOfWork.InspectionProtocolsRepository.GetTheBiggestProtocolNumber(request.DateTimeStr, cancellationToken);
            var biggestNumber = new BiggestNumberDTO()
            {
                Number = nr
            };
            return biggestNumber;
        }
    }
}
