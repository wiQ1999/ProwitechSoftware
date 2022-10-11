using MediatR;

namespace Application.Users.Commands.Requests;
public record DeleteUserCommand(Guid Id) : IRequest;
