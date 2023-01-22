using MediatR;

namespace Application.Users.Commands.Requests;

public record DeleteManyUsersCommand : IRequest
{
    public Guid[] Ids { get; init; }

	public DeleteManyUsersCommand(Guid[] ids)
    {
        Ids = ids;
	}
}
