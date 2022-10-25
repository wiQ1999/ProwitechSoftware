using System.ComponentModel.DataAnnotations;

namespace Application.Users.Commands.Requests;
public record BaseUserDataCommand
{
    [Required]
    [MinLength(6)]
    public string Login { get; set; } = null!;
    [Required]
    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public Guid RoleId { get; set; }
}
