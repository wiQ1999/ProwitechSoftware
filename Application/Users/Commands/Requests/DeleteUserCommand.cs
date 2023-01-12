using MediatR;

namespace Application.Users.Commands.Requests;

public record DeleteUserCommand : IRequest
{
    public Guid Id { get; init; }

	public DeleteUserCommand(Guid id)
    {
        Id = id;
	}
}
