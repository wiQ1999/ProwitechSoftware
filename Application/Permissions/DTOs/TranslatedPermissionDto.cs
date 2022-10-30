namespace Application.Permissions.DTOs;
public class TranslatedPermissionDto
{
    public string Source { get; set; } = default!;
    public bool Create { get; set; }
    public bool Read { get; set; }
    public bool Update { get; set; }
    public bool Delete { get; set; }
}
