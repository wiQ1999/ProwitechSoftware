namespace Application.Permissions.DTOs;
public class NullablePermissionDto
{
    public string Source { get; set; } = null!;
    public bool? Create { get; set; }
    public bool? Read { get; set; }
    public bool? Update { get; set; }
    public bool? Delete { get; set; }
}
