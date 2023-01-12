namespace Application.Users.Commands.Requests;

public record BaseUserDataCommand
{
    public string Login { get; init; } = default!;
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
    public string? Email { get; init; }
    public string? PhoneNumber { get; init; }
    public Guid? RoleId { get; init; }
}
