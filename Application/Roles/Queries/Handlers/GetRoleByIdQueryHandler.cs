using Application.Roles.DTOs;
using Application.Roles.Queries.Requests;
using AutoMapper;
using Infrastructure.Interfaces.Repositories;
using MediatR;

namespace Application.Roles.Queries.Handlers;

public class GetRoleByIdQueryHandler 
    : IRequestHandler<GetRoleByIdQuery, RoleDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetRoleByIdQueryHandler(
        IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<RoleDto> Handle(
        GetRoleByIdQuery request, CancellationToken cancellationToken)
    {
        var role = await _unitOfWork.RolesRepository.GetByIdAsync(request.Id, cancellationToken);

        return _mapper.Map<RoleDto>(role);
    }
}
