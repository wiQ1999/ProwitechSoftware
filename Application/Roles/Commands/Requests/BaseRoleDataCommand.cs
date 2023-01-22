namespace Application.Roles.Commands.Requests;

public record BaseRoleDataCommand
{
    public string Name { get; init; }

    public BaseRoleDataCommand(string name)
    {
        Name = name;
    }
}
