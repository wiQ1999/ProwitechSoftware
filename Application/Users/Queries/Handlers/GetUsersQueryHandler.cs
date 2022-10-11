using Application.Users.DTOs;
using Application.Users.Queries.Requests;
using AutoMapper;
using Infrastructure.Interfaces.Repositories;
using MediatR;

namespace Application.Users.Queries.Handlers;
public class GetUsersQueryHandler : IRequestHandler<GetUsersQuery, IEnumerable<UserDto>>
{
    private readonly IUsersRepository _usersRepository;
    private readonly IMapper _mapper;

    public GetUsersQueryHandler(IUsersRepository usersRepository, IMapper mapper)
    {
        _usersRepository = usersRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<UserDto>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
    {
        var users = await _usersRepository.GetUsersAsync(cancellationToken);
        return users.Select(u => _mapper.Map<UserDto>(u));
    }
}
