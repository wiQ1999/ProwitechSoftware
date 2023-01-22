using MediatR;

namespace Application.Roles.Commands.Requests;

public record UpdateRoleCommand : BaseRoleDataCommand, IRequest
{
    public Guid Id { get; init; }

	public UpdateRoleCommand(Guid id, string name) : base(name)
	{
		Id = id;
	}
}
