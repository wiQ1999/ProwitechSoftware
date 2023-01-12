using MediatR;

namespace Application.Users.Commands.Requests;

public record UpdateUserCommand : BaseUserDataCommand, IRequest
{
    public Guid Id { get; set; }
}
