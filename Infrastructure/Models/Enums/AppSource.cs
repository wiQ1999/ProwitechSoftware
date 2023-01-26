using System.ComponentModel;

namespace Infrastructure.Models.Enums;

public enum AppSource
{
    [Description("Role")]
    Roles,
    [Description("Użytkownicy")]
    Users,
    [Description("Uprawnienia")]
    Permissions,
    [Description("Budynki")]
    Buildings,
    [Description("Protokoły")]
    InspectionProtocols,
    [Description("Zadania")]
    InspectionTasks,
    [Description("Adresy Nieruchomości")]
    PropertyAddresses,
    [Description("Zarządcy Nieruchomości")]
    PropertyManagers,
    [Description("Nieruchomości")]
    RealProperties,
    [Description("Mieszkańcy")]
    Residents,
}
