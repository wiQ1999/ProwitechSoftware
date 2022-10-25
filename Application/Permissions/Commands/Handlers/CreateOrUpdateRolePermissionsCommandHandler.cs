using Application.Permissions.Commands.Requests;
using AutoMapper;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using Infrastructure.Models.Enums;
using Infrastructure.Models.Exceptions;
using MediatR;

namespace Application.Permissions.Commands.Handlers;

public class CreateOrUpdateRolePermissionsCommandHandler
    : IRequestHandler<CreateOrUpdateRolePermissionsCommand, Unit>
{
    private readonly IRoleRepository _roleRepository;
    private readonly IPermissionsRepository _permissionsRepository;
    private readonly IMapper _mapper;

    public CreateOrUpdateRolePermissionsCommandHandler(
        IRoleRepository roleRepository,
        IPermissionsRepository permissionsRepository,
        IMapper mapper)
    {
        _roleRepository = roleRepository;
        _permissionsRepository = permissionsRepository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(
        CreateOrUpdateRolePermissionsCommand request, CancellationToken cancellationToken)
    {
        var role = await _roleRepository.GetRoleByIdAsync(request.RoleId, cancellationToken);
        if (role == null)
            throw new NotFoundInDbExcption(AppSource.Roles, request.RoleId);

        var originalpermissions = await _permissionsRepository
            .GetRolePermissionsAsync(request.RoleId, cancellationToken);
        var requestPermissions = request.Permissions
            .Select(p => _mapper.Map<Permission>(p));

        foreach (var requestPerm in requestPermissions)
        {
            requestPerm.RoleId = request.RoleId;

            var originalPerm = originalpermissions
                .FirstOrDefault(op => op.Source == requestPerm.Source);

            if (originalPerm == null)
            {
                await _permissionsRepository
                    .CreatePermissionsAsync(requestPerm, cancellationToken);
            }
            else if (IsPermissionsPropertiesDifferent(originalPerm, requestPerm))
            {
                originalPerm.Create = requestPerm.Create;
                originalPerm.Read = requestPerm.Read;
                originalPerm.Update = requestPerm.Update;
                originalPerm.Delete = requestPerm.Delete;

                await _permissionsRepository
                    .UpdatePermissionsAsync(originalPerm, cancellationToken);
            }
        }

        return Unit.Value;
    }

    private bool IsPermissionsPropertiesDifferent(Permission p1, Permission p2) =>
        p1.Create != p2.Create ||
        p1.Read != p2.Read ||
        p1.Update != p2.Update ||
        p1.Delete != p2.Delete;
}
