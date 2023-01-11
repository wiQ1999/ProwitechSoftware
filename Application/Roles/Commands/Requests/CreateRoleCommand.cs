using MediatR;

namespace Application.Roles.Commands.Requests;

public record CreateRoleCommand : BaseRoleDataCommand, IRequest<Guid>
{
	public CreateRoleCommand(string name) : base(name)
	{ }
}
