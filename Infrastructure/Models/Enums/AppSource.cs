using System.ComponentModel;

namespace Infrastructure.Models.Enums;
public enum AppSource
{
    [Description("Role")]
    Roles,
    [Description("Użytkownicy")]
    Users,
    [Description("Uprawnienia")]
    Permissions
}
