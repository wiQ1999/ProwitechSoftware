using System.ComponentModel.DataAnnotations;

namespace Application.Roles.Commands.Requests;

public record BaseRoleDataCommand
{
    [Required]
    public string Name { get; init; }

    public BaseRoleDataCommand(string name)
    {
        Name = name;
    }
}
