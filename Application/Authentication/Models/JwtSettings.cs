namespace Infrastructure.Models.Settings;

public class JwtSettings
{
    public const string SECTION_NAME = "Jwt";

    public string Key { get; init; } = default!;
    public string Issuer { get; init; } = default!;
    public string Audience { get; init; } = default!;
    public int ExpiryHours { get; init; }
}
