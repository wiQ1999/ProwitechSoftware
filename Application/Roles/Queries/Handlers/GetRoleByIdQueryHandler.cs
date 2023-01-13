using Application.Roles.DTOs;
using Application.Roles.Queries.Requests;
using AutoMapper;
using Infrastructure.Interfaces.UnitOfWork;
using MediatR;

namespace Application.Roles.Queries.Handlers;

public class GetRoleByIdQueryHandler 
    : IRequestHandler<GetRoleByIdQuery, RoleDto>
{
    private readonly IRepositoriesUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetRoleByIdQueryHandler(
        IRepositoriesUnitOfWork unitOfWork, IMapper mapper)
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
