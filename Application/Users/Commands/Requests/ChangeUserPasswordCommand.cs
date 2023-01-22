using MediatR;

namespace Application.Users.Commands.Requests;

public record ChangeUserPasswordCommand : IRequest
{
    public Guid Id { get; init; }
    public string Password { get; init; } = default!;
}
