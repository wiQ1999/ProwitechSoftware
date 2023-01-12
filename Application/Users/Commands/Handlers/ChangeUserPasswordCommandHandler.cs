using Application.Users.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
using MediatR;

namespace Application.Users.Commands.Handlers;

public class ChangeUserPasswordCommandHandler : IRequestHandler<ChangeUserPasswordCommand>
{
    private readonly IUnitOfWork _unitOfWork;

    public ChangeUserPasswordCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Unit> Handle(ChangeUserPasswordCommand request, CancellationToken cancellationToken)
    {
        var user = await _unitOfWork.UsersRepository.GetByIdAsync(request.Id, cancellationToken);

        user.Password = request.Password;

        await _unitOfWork.UsersRepository.UpdateAsync(user, cancellationToken);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}
