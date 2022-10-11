using Application.Roles.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
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
        if (role == null)
            throw new Exception($"Nie znaleziono roli o identyfikatorze {request.Id}.");
        role.Name = request.Name;
        await _roleRepository.UpdateRoleAsync(role, cancellationToken);
        return Unit.Value;
    }
}
