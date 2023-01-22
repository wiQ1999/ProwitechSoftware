using MediatR;

namespace Application.Roles.Commands.Requests;

public record DeleteRoleCommand : IRequest
{
    public Guid Id { get; init; }

	public DeleteRoleCommand(Guid id)
	{
		Id = id;
	}
}
