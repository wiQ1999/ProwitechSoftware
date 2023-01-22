using Application.Users.DTOs;
using Application.Users.Queries.Requests;
using AutoMapper;
using Infrastructure.Interfaces.UnitOfWork;
using MediatR;

namespace Application.Users.Queries.Handlers;

public class GetUsersQueryHandler : IRequestHandler<GetUsersQuery, IEnumerable<UserDto>>
{
    private readonly IRepositoriesUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetUsersQueryHandler(IRepositoriesUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IEnumerable<UserDto>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
    {
        var users = await _unitOfWork.UsersRepository.GetAllAsync(cancellationToken);

        return users.Select(u => _mapper.Map<UserDto>(u));
    }
}
