using Application.LocalInfos.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.LocalInfos.Commands.Handlers
{
    public class CreateLocalInfoCommandHandler : IRequestHandler<CreateLocalInfoCommand, Guid>
    {
        //private readonly ILocalInfoRepository _localInfoRepository;

        //public CreateLocalInfoCommandHandler(ILocalInfoRepository localInfoRepository)
        //{
        //    _localInfoRepository = localInfoRepository;
        //}

        //public async Task<Guid> Handle(CreateLocalInfoCommand request, CancellationToken cancellationToken)
        //{
        //    LocalInfo localInfo = new LocalInfo();
        //    if (request.StaircaseNumber != null) localInfo.StaircaseNumber = request.StaircaseNumber;
        //    localInfo.LocalNumber = request.LocalNumber;
        //    return await _localInfoRepository.AddAsync(localInfo, cancellationToken);
        //}
        public Task<Guid> Handle(CreateLocalInfoCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
