using Application.Roles.DTOs;
using MediatR;

namespace Application.Roles.Queries.Requests;

public record GetRoleByIdQuery : IRequest<RoleDto>
{
    public Guid Id { get; set; }

	public GetRoleByIdQuery(Guid id)
	{
		Id = id;
	}
}
