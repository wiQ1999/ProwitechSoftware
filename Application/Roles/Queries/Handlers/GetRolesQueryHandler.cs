using Application.Roles.DTOs;
using Application.Roles.Queries.Requests;
using AutoMapper;
using Infrastructure.Interfaces.UnitOfWork;
using MediatR;

namespace Application.Roles.Queries.Handlers;

public class GetRolesQueryHandler 
    : IRequestHandler<GetRolesQuery, IEnumerable<RoleDto>>
{
    private readonly IRepositoriesUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetRolesQueryHandler(
        IRepositoriesUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IEnumerable<RoleDto>> Handle(
        GetRolesQuery request, CancellationToken cancellationToken)
    {
        var roles = await _unitOfWork.RolesRepository.GetAllAsync(cancellationToken);

        return roles.Select(r => _mapper.Map<RoleDto>(r));
    }
}
