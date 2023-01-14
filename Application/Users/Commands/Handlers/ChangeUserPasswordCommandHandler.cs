using Application.Users.Commands.Requests;
using Infrastructure.Interfaces.UnitOfWork;
using Infrastructure.Models.Domain;
using Infrastructure.Models.Enums;
using Infrastructure.Models.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Identity;

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
        if (string.IsNullOrWhiteSpace(request.Password))
            throw new RequiredValueException(AppSource.Users, nameof(request.Password));

        var user = await _unitOfWork.UsersRepository.GetByIdAsync(request.Id, cancellationToken);

        var hashed = new PasswordHasher<User>().HashPassword(user, request.Password);

        if (hashed == null)
            throw new Exception("Błąd podczas przetwarzania hasła użytkownika.");

        user.Password = hashed;

        await _unitOfWork.UsersRepository.UpdateAsync(user, cancellationToken);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}
