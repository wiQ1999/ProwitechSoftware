using Application.Authentication.DTOs;
using Application.Authentication.Queries.Requests;
using Application.Interfaces.Services;
using AutoMapper;
using Infrastructure.Interfaces.UnitOfWork;
using MediatR;

namespace Application.Authentication.Queries.Handlers;

public class RefreshTokenHandler 
    : IRequestHandler<RefreshTokenQuery, AuthenticationResponse>
{
    private readonly IRepositoriesUnitOfWork _unitOfWork;
    private readonly IPermissionsSelector _permissionsSelector;
    private readonly IMapper _mapper;
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public RefreshTokenHandler(
        IRepositoriesUnitOfWork unitOfWork,
        IPermissionsSelector permissionsSelector,
        IMapper mapper,
        IJwtTokenGenerator jwtTokenGenerator)
    {
        _unitOfWork = unitOfWork;
        _permissionsSelector = permissionsSelector;
        _mapper = mapper;
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public Task<AuthenticationResponse> Handle(
        RefreshTokenQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
