using MediatR;

namespace Application.Users.Commands.Requests;

public record CreateUserCommand : BaseUserDataCommand, IRequest<Guid>
{
    public string Password { get; init; } = default!;
}
