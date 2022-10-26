namespace Infrastructure.Models.Settings;

public class JwtSettings
{
    public const string SECTION_NAME = "Jwt";

    public string Key { get; init; } = null!;
    public string Issuer { get; init; } = null!;
    public string Audience { get; init; } = null!;
    public int ExpiryHours { get; init; }
}
