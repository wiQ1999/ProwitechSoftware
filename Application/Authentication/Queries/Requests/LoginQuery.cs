using Application.Authentication.DTOs;
using MediatR;

namespace Application.Authentication.Queries.Requests;

public record LoginQuery : IRequest<AuthenticationResponse>
{
    public string Login { get; init; } = default!;
    public string Password { get; init; } = default!;

    public LoginQuery(string login, string password)
    {
        Login = login;
        Password = password;
    }
}
