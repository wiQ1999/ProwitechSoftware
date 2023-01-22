using Application.Permissions.Commands.Requests;
using AutoMapper;
using Infrastructure.Interfaces.UnitOfWork;
using Infrastructure.Models.Domain;
using MediatR;

namespace Application.Permissions.Commands.Handlers;

public class CreateOrUpdateRolePermissionsCommandHandler
    : IRequestHandler<CreateOrUpdateRolePermissionsCommand, Unit>
{
    private readonly IRepositoriesUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CreateOrUpdateRolePermissionsCommandHandler(
        IRepositoriesUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(
        CreateOrUpdateRolePermissionsCommand request, CancellationToken cancellationToken)
    {
        var role = await _unitOfWork.RolesRepository.GetByIdAsync(request.RoleId, cancellationToken);

        var originalpermissions = await _unitOfWork.PermissionsRepository
            .GetByRoleIdAsync(request.RoleId, cancellationToken);
        var requestPermissions = request.Permissions
            .Select(p => _mapper.Map<Permission>(p));

        foreach (var requestPerm in requestPermissions)
        {
            requestPerm.RoleId = request.RoleId;

            var originalPerm = originalpermissions
                .FirstOrDefault(op => op.Source == requestPerm.Source);

            if (originalPerm == null)
            {
                await _unitOfWork.PermissionsRepository
                    .CreateAsync(requestPerm, cancellationToken);
            }
            else if (IsPermissionsPropertiesDifferent(originalPerm, requestPerm))
            {
                originalPerm.Create = requestPerm.Create;
                originalPerm.Read = requestPerm.Read;
                originalPerm.Update = requestPerm.Update;
                originalPerm.Delete = requestPerm.Delete;

                await _unitOfWork.PermissionsRepository
                    .UpdateAsync(originalPerm, cancellationToken);
            }
        }

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }

    private bool IsPermissionsPropertiesDifferent(Permission p1, Permission p2) =>
        p1.Create != p2.Create ||
        p1.Read != p2.Read ||
        p1.Update != p2.Update ||
        p1.Delete != p2.Delete;
}
