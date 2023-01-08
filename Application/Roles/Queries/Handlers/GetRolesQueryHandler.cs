using Application.Roles.DTOs;
using Application.Roles.Queries.Requests;
using AutoMapper;
using Infrastructure.Interfaces.Repositories;
using MediatR;

namespace Application.Roles.Queries.Handlers;
public class GetRolesQueryHandler : IRequestHandler<GetRolesQuery, IEnumerable<RoleDto>>
{
    private readonly IRoleRepository _roleRepository;
    private readonly IMapper _mapper;

    public GetRolesQueryHandler(IRoleRepository roleRepository, IMapper mapper)
    {
        _roleRepository = roleRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<RoleDto>> Handle(GetRolesQuery request, CancellationToken cancellationToken)
    {
        var roles = await _roleRepository.GetRolesAsync(cancellationToken);

        return roles.Select(r => _mapper.Map<RoleDto>(r));
    }
}
