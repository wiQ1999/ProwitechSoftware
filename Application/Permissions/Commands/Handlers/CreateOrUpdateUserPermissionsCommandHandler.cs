using Application.Permissions.Commands.Requests;
using AutoMapper;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using MediatR;

namespace Application.Permissions.Commands.Handlers;
public class CreateOrUpdateUserPermissionsCommandHandler
    : IRequestHandler<CreateOrUpdateUserPermissionsCommand, Unit>
{
    private readonly IPermissionsRepository _permissionsRepository;
    private readonly IMapper _mapper;

    public CreateOrUpdateUserPermissionsCommandHandler(
        IPermissionsRepository permissionsRepository,
        IMapper mapper)
    {
        _permissionsRepository = permissionsRepository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(
        CreateOrUpdateUserPermissionsCommand request, CancellationToken cancellationToken)
    {
        var userPermissions = await _permissionsRepository
            .GetUserPermissionsAsync(request.UserId, cancellationToken);
        var rolePermissions = request.UserRoleId == null ? Enumerable.Empty<Permission>() : await _permissionsRepository
            .GetRolePermissionsAsync((Guid)request.UserRoleId!, cancellationToken);
        var requestPermissions = request.Permissions
            .Select(p => _mapper.Map<Permission>(p));

        return Unit.Value;
    }
}
