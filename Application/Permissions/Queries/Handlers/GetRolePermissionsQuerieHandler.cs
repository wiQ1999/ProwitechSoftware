using Application.Permissions.DTOs;
using Application.Permissions.Queries.Requests;
using AutoMapper;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Enums;
using Infrastructure.Models.Exceptions;
using MediatR;

namespace Application.Permissions.Queries.Handlers;
public class GetRolePermissionsQuerieHandler
    : IRequestHandler<GetRolePermissionsQuerie, IEnumerable<PermissionDto>>
{
    private readonly IPermissionsRepository _permissionRepository;
    private readonly IMapper _mapper;

    public GetRolePermissionsQuerieHandler(
        IPermissionsRepository permissionRepository, IMapper mapper)
    {
        _permissionRepository = permissionRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<PermissionDto>> Handle(
        GetRolePermissionsQuerie request, CancellationToken cancellationToken)
    {
        var permissions = await _permissionRepository
            .GetUserPermissionsAsync(request.RoleId, cancellationToken);

        var nullPermissionProp = permissions.FirstOrDefault(p =>
            p.Create == null || p.Read == null ||
            p.Update == null || p.Delete == null);
        if (nullPermissionProp != null)
            throw new PermissionNullPropertyException(nullPermissionProp.Source);

        var mapped = permissions.Select(p => 
            _mapper.Map<PermissionDto>(p)).ToList();
        var sources = Enum.GetValues(typeof(AppSource))
            .Cast<AppSource>().ToList();

        if (permissions.Count() > sources.Count)
            throw new PermissionCountException();

        foreach (var source in sources)
        {
            if (!permissions.Any(p => p.Source == source)) 
                mapped.Add(CreateEmptyUserPermission(request.RoleId, source));
        }

        return mapped;
    }

    private PermissionDto CreateEmptyUserPermission(
        Guid roleId, AppSource source) =>
        new()
        {
            Id = Guid.NewGuid(),
            RoleId = roleId,
            Source = source,
            Create = false,
            Read = false,
            Update = false,
            Delete = false
        };
}
