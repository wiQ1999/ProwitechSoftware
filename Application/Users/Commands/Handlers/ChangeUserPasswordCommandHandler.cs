using Application.Users.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Enums;
using Infrastructure.Models.Exceptions;
using MediatR;

namespace Application.Users.Commands.Handlers;
public class ChangeUserPasswordCommandHandler : IRequestHandler<ChangeUserPasswordCommand>
{
    private readonly IUsersRepository _userRepository;

    public ChangeUserPasswordCommandHandler(IUsersRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<Unit> Handle(ChangeUserPasswordCommand request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetUserByIdAsync(request.Id, cancellationToken);

        user.Password = request.Password;

        await _userRepository.UpdateUserAsync(user, cancellationToken);

        return Unit.Value;
    }
}
