using System.ComponentModel.DataAnnotations;

namespace Application.Users.Commands.Requests;
public record BaseUserDataCommand
{
    [Required]
    [MinLength(6)]
    public string? Login { get; set; }
    [Required]
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public Guid RoleId { get; set; }
}
