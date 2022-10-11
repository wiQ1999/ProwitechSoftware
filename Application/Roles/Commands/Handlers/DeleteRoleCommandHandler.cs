using Application.Roles.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
using MediatR;

namespace Application.Roles.Commands.Handlers;
public class DeleteRoleCommandHandler : IRequestHandler<DeleteRoleCommand>
{
    private readonly IRoleRepository _roleRepository;

    public DeleteRoleCommandHandler(IRoleRepository roleRepository)
    {
        _roleRepository = roleRepository;
    }

    public async Task<Unit> Handle(DeleteRoleCommand request, CancellationToken cancellationToken)
    {
        await _roleRepository.DeleteRoleAsync(request.Id, cancellationToken);
        return Unit.Value;
    }
}
