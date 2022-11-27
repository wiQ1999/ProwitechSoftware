using Application.Roles.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Enums;
using Infrastructure.Models.Exceptions;
using MediatR;

namespace Application.Roles.Commands.Handlers;
public class UpdateRoleCommandHandler : IRequestHandler<UpdateRoleCommand>
{
    private readonly IRoleRepository _roleRepository;

    public UpdateRoleCommandHandler(IRoleRepository roleRepository)
    {
        _roleRepository = roleRepository;
    }

    public async Task<Unit> Handle(UpdateRoleCommand request, CancellationToken cancellationToken)
    {
        var role = await _roleRepository.GetRoleByIdAsync(request.Id, cancellationToken);

        role.Name = request.Name;

        await _roleRepository.UpdateRoleAsync(role, cancellationToken);

        return Unit.Value;
    }
}
