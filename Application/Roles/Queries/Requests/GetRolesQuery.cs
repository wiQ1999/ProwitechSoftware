using Application.Roles.DTOs;
using MediatR;

namespace Application.Roles.Queries.Requests;
public record GetRolesQuery : IRequest<IEnumerable<RoleDto>>;
