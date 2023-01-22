using Application.Users.Commands.Requests;
using Infrastructure.Interfaces.UnitOfWork;
using Infrastructure.Models.Domain;
using Infrastructure.Models.Enums;
using Infrastructure.Models.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Application.Users.Commands.Handlers;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Guid>
{
    private readonly IRepositoriesUnitOfWork _unitOfWork;
    private readonly IPasswordHasher<User> _hasher;

    public CreateUserCommandHandler(IRepositoriesUnitOfWork unitOfWork, IPasswordHasher<User> hasher)
    {
        _unitOfWork = unitOfWork;
        _hasher = hasher;
    }

    public async Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        if (string.IsNullOrWhiteSpace(request.Password))
            throw new RequiredValueException(AppSource.Users, nameof(request.Password));

        if (request.RoleId != null)
            await _unitOfWork.RolesRepository.GetByIdAsync((Guid)request.RoleId, cancellationToken);

        User user = new()
        {
            Login = request.Login,
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email,
            PhoneNumber = request.PhoneNumber,
            RoleId = request.RoleId
        };

        var hashed = _hasher.HashPassword(user, request.Password);

        user.Password = hashed;

        var guid = await _unitOfWork.UsersRepository.CreateAsync(user, cancellationToken);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return guid;
    }
}
