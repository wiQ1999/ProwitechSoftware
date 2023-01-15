using Application.Users.Commands.Requests;
using Infrastructure.Interfaces.UnitOfWork;
using Infrastructure.Models.Domain;
using Infrastructure.Models.Enums;
using Infrastructure.Models.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Application.Users.Commands.Handlers;

public class ChangeUserPasswordCommandHandler : IRequestHandler<ChangeUserPasswordCommand>
{
    private readonly IRepositoriesUnitOfWork _unitOfWork;
    private readonly IPasswordHasher<User> _hasher;

    public ChangeUserPasswordCommandHandler(IRepositoriesUnitOfWork unitOfWork, IPasswordHasher<User> hasher)
    {
        _unitOfWork = unitOfWork;
        _hasher = hasher;
    }

    public async Task<Unit> Handle(ChangeUserPasswordCommand request, CancellationToken cancellationToken)
    {
        if (string.IsNullOrWhiteSpace(request.Password))
            throw new RequiredValueException(AppSource.Users, nameof(request.Password));

        var user = await _unitOfWork.UsersRepository.GetByIdAsync(request.Id, cancellationToken);

        var hashed = _hasher.HashPassword(user, request.Password);

        if (hashed == null)
            throw new Exception("Błąd podczas przetwarzania hasła użytkownika.");

        user.Password = hashed;

        await _unitOfWork.UsersRepository.UpdateAsync(user, cancellationToken);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}
