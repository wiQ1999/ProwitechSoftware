using Application.Users.DTOs;
using MediatR;

namespace Application.Users.Queries.Requests;
public record GetUserByIdQuery(Guid Id) : IRequest<UserDto>;
