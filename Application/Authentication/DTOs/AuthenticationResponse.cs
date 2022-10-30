namespace Application.Authentication.DTOs;

public record AuthenticationResponse()
{
    public string? Token { get; init; }
    public bool IsGenerated { get; init; }
}
