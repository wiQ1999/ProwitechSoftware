using Application.Authentication.DTOs;
using MediatR;

namespace Application.Authentication.Queries.Requests;

public record RefreshTokenQuery : IRequest<AuthenticationResponse>
{
    public Guid UserId { get; set; }

    public string CurrentToken { get; init; } = default!;

    public RefreshTokenQuery(Guid userId, string currentToken)
    {
        UserId = userId;
        CurrentToken = currentToken;
    }
}
