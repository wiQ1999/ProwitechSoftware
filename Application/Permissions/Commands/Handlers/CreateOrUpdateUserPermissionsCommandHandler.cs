using Application.Permissions.Commands.Requests;
using AutoMapper;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using Infrastructure.Models.Enums;
using Infrastructure.Models.Exceptions;
using MediatR;

namespace Application.Permissions.Commands.Handlers;
public class CreateOrUpdateUserPermissionsCommandHandler
    : IRequestHandler<CreateOrUpdateUserPermissionsCommand, Unit>
{
    private readonly IUsersRepository _usersRepository;
    private readonly IPermissionsRepository _permissionsRepository;
    private readonly IMapper _mapper;

    public CreateOrUpdateUserPermissionsCommandHandler(
        IUsersRepository usersRepository,
        IPermissionsRepository permissionsRepository,
        IMapper mapper)
    {
        _usersRepository = usersRepository;
        _permissionsRepository = permissionsRepository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(
        CreateOrUpdateUserPermissionsCommand request, CancellationToken cancellationToken)
    {
        var user = await _usersRepository.GetUserByIdAsync(request.UserId, cancellationToken);
        if (user == null)
            throw new NotFoundInDbExcption(AppSource.Users, request.UserId);

        var originalpermissions = await _permissionsRepository
            .GetUserPermissionsAsync(request.UserId, cancellationToken);
        var requestPermissions = request.Permissions
            .Select(p => _mapper.Map<Permission>(p));

        foreach (var requestPerm in requestPermissions)
        {
            requestPerm.UserId = request.UserId;

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
