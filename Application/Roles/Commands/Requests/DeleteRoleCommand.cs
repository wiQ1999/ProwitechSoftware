using MediatR;

namespace Application.Roles.Commands.Requests;
public record DeleteRoleCommand(Guid Id) : IRequest;
