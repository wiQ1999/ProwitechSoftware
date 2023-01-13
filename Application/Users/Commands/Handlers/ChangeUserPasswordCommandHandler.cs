using Application.Users.Commands.Requests;
using Infrastructure.Interfaces.UnitOfWork;
using MediatR;

namespace Application.Users.Commands.Handlers;

public class ChangeUserPasswordCommandHandler : IRequestHandler<ChangeUserPasswordCommand>
{
    private readonly IRepositoriesUnitOfWork _unitOfWork;

    public ChangeUserPasswordCommandHandler(IRepositoriesUnitOfWork unitOfWork)
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
