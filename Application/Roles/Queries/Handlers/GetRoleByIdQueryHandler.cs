using Application.Roles.DTOs;
using Application.Roles.Queries.Requests;
using AutoMapper;
using Infrastructure.Interfaces.Repositories;
using MediatR;

namespace Application.Roles.Queries.Handlers;

public class GetRoleByIdQueryHandler 
    : IRequestHandler<GetRoleByIdQuery, RoleDto>
{
    private readonly IRoleRepository _roleRepository;
    private readonly IMapper _mapper;

    public GetRoleByIdQueryHandler(
        IRoleRepository roleRepository, IMapper mapper)
    {
        _roleRepository = roleRepository;
        _mapper = mapper;
    }

    public async Task<RoleDto> Handle(
        GetRoleByIdQuery request, CancellationToken cancellationToken)
    {
        var role = await _roleRepository.GetRoleByIdAsync(request.Id, cancellationToken);

        return _mapper.Map<RoleDto>(role);
    }
}
