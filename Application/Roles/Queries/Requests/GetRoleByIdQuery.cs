using Application.Roles.DTOs;
using MediatR;

namespace Application.Roles.Queries.Requests;
public record GetRoleByIdQuery(Guid Id) : IRequest<RoleDto>;
