using Application.Users.DTOs;
using MediatR;

namespace Application.Users.Queries.Requests;

public record GetUserByIdQuery : IRequest<UserDto>
{
    public Guid Id { get; init; }

	public GetUserByIdQuery(Guid id)
	{
		Id = id;
	}
}
