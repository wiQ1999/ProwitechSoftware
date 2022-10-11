using Application.Users.DTOs;
using MediatR;

namespace Application.Users.Queries.Requests;
public record GetUsersQuery : IRequest<IEnumerable<UserDto>>;
