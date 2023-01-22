using MediatR;

namespace Application.Roles.Commands.Requests;

public record DeleteManyRolesCommand : IRequest
{
    public Guid[] Ids { get; init; }

	public DeleteManyRolesCommand(Guid[] ids)
	{
		Ids = ids;
	}
}
